<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	//int[,] matrix = new int[2,3];
	int[,] matrix = new int[2, 3]{
		{1,2,3},
		{4,5,6}
	};
	matrix.Dump();
	
	for(int r =0; r<matrix.GetLength(0); r++){
		for(int c=0; c<matrix.GetLength(1);c++){
			matrix[r,c] = 1;
		}
	}
	
	matrix.Dump();

	int[][] jagged = new int[3][]{
		new int[] {1,2,3},	
		new int[] {4,5},	
		new int[] {6}	
	};
	
	for (int r = 0; r<jagged.Length;r++){
		for(int c =0; c<jagged[r].Length;c++){
			jagged[r][c] = jagged[r][c] +1;
		}
	}
	jagged.Dump();

	int[][] jagged1 = new int[3][]{
		Enumerable.Range(1,3).ToArray(),
		Enumerable.Range(2,2).ToArray(),
		Enumerable.Range(50,5).ToArray()

	};
	jagged1.Dump();

	System.Collections.Hashtable 
}

// Define other methods, classes and namespaces here
