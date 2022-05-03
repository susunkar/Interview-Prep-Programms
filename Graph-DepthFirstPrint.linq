<Query Kind="Program" />

void Main()
{
	Dictionary<char,char[]> graph= new Dictionary<char,char[]>();
	graph.Add('a', new char[] { 'c','b' });
	graph.Add('b', new char[] { 'd' });
	graph.Add('c', new char[] { 'e' });
	graph.Add('d', new char[] { 'f' });
	graph.Add('e', new char[] { });
	graph.Add('f', new char[] {});

	graph.Dump();
	DepthFistPrintReq(graph,'a');
	//Output: abdfce
	
	void DepthFirstPrint(Dictionary<char,char[]> graph, char source){
		Stack<char> grst= new Stack<char>();
		grst.Push(source);
		StringBuilder dfs = new StringBuilder();
		
		while(grst.Count>0 && grst != null){
			char node = grst.Pop();
			dfs.Append(node);
			
			char[] neighbor = graph[node];
			foreach (var nb in neighbor)
			{
				grst.Push(nb);
			}
		}
		dfs.ToString().Dump();
	}
	void DepthFistPrintReq (Dictionary<char,char[]> graph, char source){
		Console.WriteLine(source);
		foreach (var neighbor in  graph[source])
		{
			DepthFistPrintReq(graph, neighbor);
		}
	}
}

// You can define other methods, fields, classes and namespaces here