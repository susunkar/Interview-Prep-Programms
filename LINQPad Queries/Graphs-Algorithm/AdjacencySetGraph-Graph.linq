<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

//AdjacencySet graph representation is good, but we can create
void Main()
{
	AdjacencySetGraph adjMatgrt = new AdjacencySetGraph(GraphType.DIRECTED, 5);
	adjMatgrt.addEdge(0, 1);
	adjMatgrt.addEdge(0, 2);
	adjMatgrt.addEdge(1, 4);
	adjMatgrt.addEdge(2, 3);
	adjMatgrt.addEdge(3, 1);
	adjMatgrt.addEdge(3, 4);
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

public class Node
{
	private int vertexNumber;
	private List<int> adjancencySet = new List<int>();
	
	public Node (int vertexNumber){
		this.vertexNumber = vertexNumber;
	}
	public int getVertexNumber(){
		return vertexNumber;
	}
	public void addEdge(int vertexNumber){
		adjancencySet.Add(vertexNumber);
	}
	
	public List<int> getAdjancentVertices(){
		
		return adjancencySet;
	}
	
}
public class AdjacencySetGraph : IGraph
{
	private List<Node> vertextList = new List<UserQuery.Node>();
	private GraphType _grtType = GraphType.DIRECTED;
	private int _numVertices = 0;

	public AdjacencySetGraph(GraphType grt, int numberVertices)
	{
		this._numVertices = numberVertices;
		this._grtType = grt;

		for (int v = 0; v < numberVertices; v++)
		{			
			vertextList.Add(new Node(v));
		}
		vertextList.Dump();
	}

	public GraphType Graphtype
	{
		get { return _grtType; }
	}


	public void addEdge(int v1, int v2)
	{
		if(v1 >=_numVertices || v1<0 || v2>= _numVertices || v2<0){
			throw new ArgumentException( "Vertex number is not valid");
		}
		GetNode(v1).addEdge(v2);
		
		if(_grtType == UserQuery.GraphType.DIRECTED){
			GetNode(v2).addEdge(v1);
		}
	}

	private Node GetNode(int v1)
	{
		foreach (var element in vertextList)
		{
			if (element.getVertexNumber() == v1)
			{
				return element;
			}
		}
		return new Node(v1);
	}

	public List<int> getAdjacentVertices(int v)
	{
		return GetNode(v).getAdjancentVertices();
	}

	public void Display()
	{
		vertextList.Dump();
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
	}
	public void BeardthFirstTraversal(int[] visted, int currenctNode)
	{
		Queue<int> queue = new Queue<int>();
		queue.Enqueue(currenctNode);
		
		while(queue.Count != 0 )
		{
			int vertex = queue.Dequeue();
			
			if(visted[currenctNode] ==1)
			{
				continue;
			}
			Console.WriteLine(vertex + "->");
			
			visted[vertex] =1;
			
			List<int> list = getAdjacentVertices(vertex);

			foreach (var element in list)
			{
				if(visted[element] != 1)
				queue.Enqueue(element);
			}
		}
	}
}