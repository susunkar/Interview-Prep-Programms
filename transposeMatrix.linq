<Query Kind="Program" />

void Main()
{
	int[][] matrix = new int[][] {new int[] 
	{ 1, 2, 3 }, new int[] 
	{ 4, 5, 6}};
	
	Transpose(matrix).Dump();
	
 	int[][] Transpose(int[][] matrix)
	{
		int r = matrix.Length;
		int c = matrix[0].Length;

		int[][] transpose = new int[c][];

		//Transpose
		for (int i = 0; i < transpose.Length; i++)
		{
			transpose[i] = new int[r];
			for (int j = 0; j < transpose[i].Length; j++)
			{
				transpose[i][j] = matrix[j][i];
			}
		}
		return transpose;
	}
}

// You can define other methods, fields, classes and namespaces here