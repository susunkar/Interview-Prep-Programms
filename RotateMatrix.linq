<Query Kind="Program" />

void Main()
{
	int[][] matrix =new int[3][] {
			new int[] {1,2,3},
			new int[] {4,5,6},
			new int[] {7,8,9}
	};
	Rotate(matrix);
	void Rotate(int[][] matrix)
	{
		//Transpose
		for (int r = 0; r < matrix.Length; r++)
		{
			for (int c = r; c < matrix[r].Length; c++)
			{
				Swapp(ref matrix, r, c);
			}
		}

		//Reverse the matrix
		for (int r = 0; r < matrix.Length; r++)
		{
			int i = 0;
			int j = matrix[r].Length - 1;
			while (i < j)
			{
				int temp = matrix[r][i];
				matrix[r][i]= matrix[r][j];
				matrix[r][j]= temp;
				i++;
				j--;
			}
		}
		matrix.Dump();
	}
	 void Swapp(ref int[][] matrix, int r, int c)
	{
		int tem = matrix[r][c];
		matrix[r][c] = matrix[c][r];
		matrix[c][r] = tem;
	}
}

// You can define other methods, fields, classes and namespaces here