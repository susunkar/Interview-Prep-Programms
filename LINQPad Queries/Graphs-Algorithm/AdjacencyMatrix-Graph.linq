<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	AdjacencyMatrixGraph adjMatgrt = new AdjacencyMatrixGraph(GraphType.DIRECTED, 6);
	adjMatgrt.addEdge(0,1);
	adjMatgrt.addEdge(0,2);
	adjMatgrt.addEdge(0,3);
	adjMatgrt.addEdge(1,5);
	adjMatgrt.addEdge(2,3);
	adjMatgrt.addEdge(3,4);
	adjMatgrt.addEdge(4,5);
	adjMatgrt.Display();
	adjMatgrt.getAdjacentVertices(3).Dump();
	adjMatgrt.getAdjacentVertices(4).Dump();
	adjMatgrt.getAdjacentVertices(0).Dump();
}
public enum GraphType
{
	UNDIRECT = 0,
	DIRECTED = 1
}

public interface IGraph
{
	GraphType Graphtype { get; }
	
	void addEdge(int v1, int v2);
		
	List<int> getAdjacentVertices(int v);
}

public class AdjacencyMatrixGraph : IGraph
{
	private int[,] _adjancyMatrix ;
	private GraphType _grtType = GraphType.DIRECTED;
	private int _numVertices = 0;

	public AdjacencyMatrixGraph(GraphType grt, int numberVertices){
		this._numVertices = numberVertices;
		this._grtType = grt;
		
		_adjancyMatrix = new int[numberVertices,numberVertices];

		//Setting all to zero default
		for (int i = 0; i < numberVertices; i++)
		{
			for (int j = 0; j < numberVertices; j++)
				_adjancyMatrix[i,j] = 0;
		}
		_adjancyMatrix.Dump();
	}

	public GraphType Graphtype
	{
		get { return _grtType; }
	}

	public void addEdge(int v1, int v2)
	{
		if(v1 >= _numVertices || v1 < 0 || v2>= _numVertices || v2<0)
		{
			throw new ArgumentException("Vertex number is not valid");
		}
		
		_adjancyMatrix[v1,v2] = 1;

		if (_grtType == UserQuery.GraphType.UNDIRECT)
		{
			_adjancyMatrix[v2, v1] = 1;
		}
		
	}

	public List<int> getAdjacentVertices(int v)
	{
		if (v >= _numVertices || v < 0)
			throw new ArgumentException("Vertex number is not valid");

		List<int> adjanceVerticesList = new List<int>();

		for (int i = 0; i < _numVertices; i++)
		{
			if (_adjancyMatrix[v, i] == 1)
			{
				adjanceVerticesList.Add(i);
			}
		}
		
		adjanceVerticesList.Sort();
		
		return adjanceVerticesList;
	}
	
	public void Display(){
		_adjancyMatrix.Dump();
	}
	public void DepthFirstTraversal(int[] visited, int currenctNode)
	{
		if (visited[currenctNode] == 1)
			return;

		visited[currenctNode] = 1;
		List<int> list = getAdjacentVertices(currenctNode);
		foreach (var element in list)
		{
			DepthFirstTraversal(visited, element);
		}

		//This like post-order, node is processed at last
		Console.Write("{currenctNode}->");
		
		/*
		// This for-loop ensures that all nodes are covered even for an unconnected graph
			for(int i =0; i<N ; i++) {
			DepthFirstTraversal (
			}
			
		*/

	}

	public static void depthFirtstTraversel(IGraph graph, int[] visited, int currentVertex)
	{
		if (visited[currentVertex] == 1)
		{
			return;
		}
		visited[currentVertex] = 1;
		List<int> list = graph.getAdjacentVertices(currentVertex);
		foreach (var vertex in list)
		{
			depthFirtstTraversel(graph, visited, vertex);

		}
		
		//This like post-order, node is processed at last
		Console.Write("{currentVertex}->");

	}
	public void BeardthFirstTraversal(int[] visted, int currenctNode)
	{
		Queue<int> queue = new Queue<int>();
		queue.Enqueue(currenctNode);

		while (queue.Count != 0)
		{
			int vertex = queue.Dequeue();

			if (visted[currenctNode] == 1)
			{
				continue;
			}
			Console.WriteLine(vertex + "->");

			visted[vertex] = 1;

			List<int> list = getAdjacentVertices(vertex);

			foreach (var element in list)
			{
				if (visted[element] != 1)
					queue.Enqueue(element);
			}
		}
	}
}