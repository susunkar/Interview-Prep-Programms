<Query Kind="Program" />

/*
Say that you are a traveler on a 2D grid. You begin in the top-left corner and your goal is to travel to the bottom-right corner.
You may only move down or right.

In how many ways can you travel to the goal on a grid with dimensions m * n?
*/
void Main()
{
	int [,] grid = new int [18,18];
	
	gridTraveler(grid).Dump();
	
}
public long gridTraveler(int[,] grid){
	Dictionary<string, long> hashResult = new Dictionary<string, long>();
	
	return gridTraveler(grid, grid.GetLength(0), grid.GetLength(1),hashResult);
	
}
public long gridTraveler(int[,] grid, int m, int n, Dictionary<string, long> hashResult ){
	if(m==1 && n ==1) return 1;
	if(m==0 || n ==0) return 0;
	string mn = string.Join(',',m,n);
	if(hashResult.ContainsKey(mn)) return hashResult[mn];

	hashResult.Add (mn, gridTraveler (grid, m - 1, n,hashResult) +
			gridTraveler (grid, m, n - 1,hashResult));

	return hashResult[mn];
	
}

