<Query Kind="Program" />

//https://youtu.be/tWVWeAqZ0WU?t=3902
void Main()
{
	Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>() {
		{'0',new List<char>(){'8','1','5'}},
		{'1',new List<char>(){'0'}},
		{'5',new List<char>(){'0','8'}},
		{'8',new List<char>(){'0','5'}},
		{'2',new List<char>(){'3','4'}},
		{'3',new List<char>(){'2','4'}},
		{'4',new List<char>(){'3','2'}}
	};
	connectedComponentCount(graph).Dump();
}
int connectedComponentCount(Dictionary<char,List<char>> graph){
	HashSet<char> visited = new HashSet<char>();
	int count =0 ;
	foreach (var node in graph)
	{
		if(explore(graph, node.Key, visited)){
			count+=1;
		}
	}
	return count;
}

bool explore (Dictionary<char, List<char>> graph, char node, HashSet<char> visited)
{
	if (visited.Contains (node)) return false;
	visited.Add(node);
	foreach (var neighbor in graph[node])
		{
			explore (graph, neighbor,visited);
		}
	return true;
}



