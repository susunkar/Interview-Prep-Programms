<Query Kind="Program" />

void Main()
{
	int[][] mygrid = new int[3][] {
		new int[3],
		new int[3],
		new int[3],
	};
	Hashtable memoization = new Hashtable();
	mygrid.Dump();
	GridTraveler(mygrid,3,3).Dump();

	int GridTraveler(int[][] grid, int r, int c)
	{
		string key = $"{r},{c}";
		if(memoization.Contains(key)){
			return (int) memoization[key];
		}
		if(r == 1 && c == 1) return 1;
		if(r == 0 || c == 0) return 0;
		//if(r<0 || r>=grid.Length || c<0 || c>=grid[r].Length) return 0;
		
		memoization[key]= GridTraveler(grid, r-1, c ) + GridTraveler(grid, r, c-1 );
		return (int)memoization[key];
	}
}

// You can define other methods, fields, classes and namespaces here