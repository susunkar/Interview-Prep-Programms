<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

//AdjacencyList graph representation is not good, but we can create
void Main()
{
	AdjacencyListGraph adjMatgrt = new AdjacencyListGraph(GraphType.DIRECTED, 5);
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

public class Node{
	public int VertexId;
	public Node next;
}
public class AdjacencyListGraph : IGraph
{
	private List<Node> _adjancyList;
	private GraphType _grtType = GraphType.DIRECTED;
	private int _numVertices = 0;

	public AdjacencyListGraph(GraphType grt, int numberVertices)
	{
		this._numVertices = numberVertices;
		this._grtType = grt;

		_adjancyList = new List<UserQuery.Node>();
	
		for (int  v =0 ; v <numberVertices; v++)
		{
			Node temp = new Node {
				VertexId = v,
				next =null
			};
			
			_adjancyList.Add(temp);
		}
		_adjancyList.Dump();
	}

	public GraphType Graphtype
	{
		get { return _grtType; }
	}

	
	public void addEdge(int v1, int v2)
	{
		var _node = GetNode(v1);
		
		if(_node == null){
			_adjancyList.Add(
				new Node
				{
					VertexId = v1,
					next = new Node {
						VertexId = v2,
						next = null
					}
				}
			);
		}
		else {
			Node temp2 = new Node{
				VertexId = v2,
				next = _node.next
			};
			_node.next = temp2;
		}
		
		_adjancyList.Dump();
	}

	private Node GetNode(int v1)
	{
		foreach (var element in _adjancyList)
		{
			if (element.VertexId == v1)
			{
				return element;
			}

		}
		return null;
	}

	public List<int> getAdjacentVertices(int v)
	{
		List<int> adjanceVerticesList = new List<int>();

		foreach (var vertex in _adjancyList)
		{
			if(vertex.VertexId == v){
			var temp = vertex;
				while(temp != null){
					adjanceVerticesList.Add(temp.VertexId);
					temp = temp.next;
				}
			adjanceVerticesList.Remove(vertex.VertexId);
			}
		}

		return adjanceVerticesList;
	}

	public void Display()
	{
		_adjancyList.Dump();
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
	//This implementation for AdjacencyList
	public int getIndegreeForList(int v)
	{
		if (v < 0 || v >= _numVertices)
		{
			throw new AggregateException("vertex number is not valid");
		}
		int indegree = 0;
		for (int i = 0; i < _numVertices; i++)
		{
			if (getAdjacentVertices(i).Contains(v))
			{
				indegree++;
			}
		}
		return indegree;
	}

}