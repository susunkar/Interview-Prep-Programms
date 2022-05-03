<Query Kind="Program" />

void Main()
{
	Dictionary<char, char[]> graph = new Dictionary<char, char[]>();
	graph.Add('a', new char[] { 'c', 'b' });
	graph.Add('b', new char[] { 'd' });
	graph.Add('c', new char[] { 'e' });
	graph.Add('d', new char[] { 'f' });
	graph.Add('e', new char[] { });
	graph.Add('f', new char[] { });

	graph.Dump();
	BreadthFirstPrint(graph, 'a');
	//Output: acbedf

	void BreadthFirstPrint(Dictionary<char, char[]> graph, char source)
	{
		Queue<char> queue = new Queue<char>();
		StringBuilder stbuilder = new StringBuilder();
		queue.Enqueue(source);
		while(queue.Count>0 && queue != null){
			char dequeNode = queue.Dequeue();
			stbuilder.Append(dequeNode);

			char[] neighbor = graph[dequeNode];
			foreach (var nb in neighbor)
			{
				queue.Enqueue(nb);
			}
		}
		stbuilder.ToString().Dump();
	}
	
}

// You can define other methods, fields, classes and namespaces here