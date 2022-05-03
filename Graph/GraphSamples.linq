<Query Kind="Program" />

/*
edges: [  			graph: {
	[i,j],				i:[j,k],
	[k,i],				j:[i],
	[m,k],		=>		k:[i,m,l],
	[k,l],				m:[k],
	[o,n]				l:[k],
]						o:[n],
						n:[o]
						}
*/
void Main()
{
	List<List<char>> edges = new List<List<char>> (){
	new List<char> (){'i','j'},
	new List<char> (){'k','i'},
	new List<char> (){'m','k'},
	new List<char> (){'k','l'},
	new List<char> (){'o','n'}
	};
	var graph = createUndirectGraphFromAdjList(edges);
	var visited = new HashSet<char>();
	var result = hasPath (graph, 'i', 'k', visited).Dump();
	
}

bool hasPath (Dictionary<char, List<char>> graph, char source, char dist, HashSet<char> visited)
{
	
	if(source == dist) return true;
	if(visited.Contains(source)) return false;
	
	visited.Add(source);
	
	foreach (var curr in graph[source])
	{
		if (hasPath (graph, curr, dist,visited))
		{
			return true;
		}
		
	}
	return false;
}

public Dictionary<char, List<char>> createUndirectGraphFromAdjList(List<List<char>> Edges){
	Dictionary<char, List<char>> graph = new Dictionary<char,List<char>>();
	
	foreach (var ed in Edges)
	{
		var a = ed[0];
		var b = ed[1];
		if(!graph.ContainsKey(a)){
			graph.Add(a,new List<char>());
		}
		if (!graph.ContainsKey (b))
		{
			graph.Add (b, new List<char>());
		}
		graph[a].Add (b);
		graph[b].Add (a);
			
	}
	
	return graph;
} 