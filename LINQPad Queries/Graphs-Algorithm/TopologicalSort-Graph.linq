<Query Kind="Program" />

//This is TopologicalSort is implemented on AdjacencyMatrix

void Main()
{
	AdjacencyMatrix adjMatgrt = new AdjacencyMatrix(GRAPHTYPE.DIRECTED, 5);
	adjMatgrt.addEdge(0, 1);
	adjMatgrt.addEdge(0, 2);
	adjMatgrt.addEdge(1, 3);
	adjMatgrt.addEdge(2, 4);
	adjMatgrt.addEdge(4, 1);
	adjMatgrt.addEdge(4, 3);
	
	adjMatgrt.Dump();
	
	var topologysort = TopologicalSort(adjMatgrt);
	
	topologysort.Dump();

}
public enum GRAPHTYPE{
	DIRECTED = 0,
	UNDIRECT = 1
}
public interface IGraph
{
	public List<int> getAdjacencyVertices (int vertex);
	public void addEdge(int vertex1, int vertex2);
	public int getIndegree(int vertex);

	GRAPHTYPE Graphtype { get; }
}
public class AdjacencyMatrix : IGraph
{
	private GRAPHTYPE _grtType = GRAPHTYPE.DIRECTED;
	private int _numberofVerties = 0;
	private int[,] _adjacencyMatrix;

	public AdjacencyMatrix(GRAPHTYPE graphType, int numVertex){
		this._grtType = graphType;
		this._numberofVerties = numVertex;
		this._adjacencyMatrix = new int[numVertex,numVertex];
	}

	public GRAPHTYPE Graphtype
	{
		get {return _grtType;}
	}
	

	public void addEdge(int vertex1, int vertex2)
	{
		if (vertex1 >= _numberofVerties || vertex1 < 0 || vertex2 >= _numberofVerties || vertex2 < 0)
		{
			throw new ArgumentException("Vertex number is not valid");
		}

		_adjacencyMatrix[vertex1, vertex2] = 1;

		if (_grtType == GRAPHTYPE.UNDIRECT)
		{
			_adjacencyMatrix[vertex2, vertex1] = 1;
		}
	}

	public List<int> getAdjacencyVertices(int vertex)
	{
		if (vertex >= _numberofVerties || vertex < 0)
			throw new ArgumentException("Vertex number is not valid");

		List<int> adjanceVerticesList = new List<int>();

		for (int i = 0; i < _numberofVerties; i++)
		{
			if (_adjacencyMatrix[vertex, i] == 1)
			{
				adjanceVerticesList.Add(i);
			}
		}

		adjanceVerticesList.Sort();

		return adjanceVerticesList;
	}

	public int getNumVertices()
	{
		return _numberofVerties;
	}
	
	public int getIndegree(int vertex)
	{
		if (vertex < 0 || vertex >= _numberofVerties)
		{
			throw new AggregateException("vertex number is not valid");
		}
		int indegree = 0;
		for (int i = 0; i < getNumVertices(); i++)
		{
			if (_adjacencyMatrix[i,vertex] != 0)
			{
				indegree++;
			}
		}
		return indegree;
	}
}



public static List<int> TopologicalSort(AdjacencyMatrix graph){
	Queue<int> queue = new Queue<int>();
	Dictionary<int,int> indegreeMap = new Dictionary<int, int>();
	
	for(int vertex= 0; vertex<graph.getNumVertices(); vertex++){
	
		int indegree = graph.getIndegree(vertex);
		indegreeMap.Add(vertex,indegree);
		
		if(indegree == 0) {
			queue.Enqueue(vertex);
		}
	}
	
	List<int> sortedList = new List<int>();
	
	while(queue.Count != 0){
		
		int vertex = queue.Dequeue();
		sortedList.Add(vertex);
		
		List<int> adjacentVertices = graph.getAdjacencyVertices(vertex);
		
		foreach (var v in adjacentVertices)
		{
			int updatedIndegree = indegreeMap.GetValueOrDefault(v) -1;
			indegreeMap.Remove(v);
			indegreeMap[v] = updatedIndegree;
			
			if(updatedIndegree == 0){
				queue.Enqueue(v);
			}
		}
	}
	
	
	if(sortedList.Count != graph.getNumVertices()){
		throw new Exception("The graph had a cycle!");
	}
	//sortedList.Sort();
	
	return sortedList;
}
// Define other methods, classes and namespaces here
