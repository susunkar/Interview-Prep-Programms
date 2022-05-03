<Query Kind="Program" />

/*
Graph = nodes + edges
directed graph, undirected graph
A -> C, B
C -> E
E -> B
B -> D
F -> D

Adjacency list: Key (Node), Value (Array)
{
	a: [c,b],
	b: [d],
	c: [e],
	d: [],
	e: [b],
	f: [d]
}
DFS:
1. a, c, e, b, d
2. a, b, d

BFS:
 1. a, c, b, 
*/
void Main()
{
	Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>(){
	 {'a' , new List<char> (){'b','c'}},
	 {'b' , new List<char> (){'d'}},
	 {'c' , new List<char> (){'e'}},
	 {'d' , new List<char> (){'f'}},
	 {'e' , new List<char> (){}},
	 {'f' , new List<char> (){}}
	};
	graph.Dump();
	"DFS".Dump();
	DFS(graph,'a');
	
	"DFSReq".Dump();
	DFSReq(graph,'a');
	
	"BFS".Dump();
	BFS(graph,'a');
}

public void DFS(Dictionary<char, List<char>> graph, char startNode){
	if(string.IsNullOrEmpty(startNode.ToString())) return ;
	
	Stack<char> stc = new Stack<char>();
	stc.Push(startNode);
	
	while (stc.Count>0)
	{
		char popEL = stc.Pop();
		Console.WriteLine(popEL);
		var nods = graph[popEL].OrderByDescending(x=>x).ToList();
		nods.ForEach(x=>stc.Push(x));
	}
}
public void DFSReq(Dictionary<char, List<char>> graph, char startNode){
	if(string.IsNullOrEmpty(startNode.ToString())) return ;
	Console.WriteLine(startNode);
	foreach (var neighbor in graph[startNode])
	{
		DFSReq(graph, neighbor);
	}
}

public void BFS (Dictionary<char, List<char>> graph, char startNode){
	if(string.IsNullOrEmpty(startNode.ToString())) return ;
	
	Queue<char> que = new Queue<char>();
	que.Enqueue(startNode);
	
	while (que.Count>0)
	{
		var EL = que.Dequeue();
		Console.WriteLine (EL);
		var nods = graph [EL].OrderByDescending (x => x).ToList();
		nods.ForEach (x => que.Enqueue(x));
	}
}

