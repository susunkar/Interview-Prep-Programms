<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	//int[] arr = new int[] {2, 3, 4 ,1, 5}; //3
	//int[] arr = new int[] {4, 3, 1,2};// 3
	//int[] arr = new int[] {1, 3, 5, 2, 4};// 3
	int[] arr = new int[] {5,3,4,6,1,2,7};// 3
	bool[] visited = new bool[arr.Length];
    Dictionary <int,int> Positionvalue = new Dictionary<int, int>();
    
    for (int i =0;i<arr.Length;i++)
    {
        Positionvalue.Add(i,arr[i]);
    }
    int counter =0;

    foreach (var a in Positionvalue)
    {
        var position = a.Key;
        var value = a.Value;
    
        if(visited[value - 1]){
            continue;
        }
        int count = 0;
        while (!visited[value - 1])
        {
        	visited[value - 1] = true;
        	value = arr[value - 1];
        	count++;
        }
    counter += count - 1;
    }

	counter.Dump();
	visited.Dump();
	arr.Dump();
}

// Define other methods, classes and namespaces here