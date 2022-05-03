<Query Kind="Program" />

void Main()
{
	//Write a function that takes two inputs n and m and outputs the number of unique paths from the top left corner to bottom
	//right corner of a n x m grid.

	//Constraints : you can only move down or right 1 unit at a time
	/*
	int[][] grid = new int[][] {
		new int [] {1,2,3},
		new int [] {4,5}
	};
		
	grid.Length.Dump();
	grid.GetLength(0).Dump();
	
	for (int i = 0; i < grid.Length; i++)
	{
		for	(int j=0; j<grid[i].Length;j++){
			grid[i][j].Dump();
		}
	}
*/
	int[,] grd = new int[,]{
		{1,2,3},
		{5,4,-1},
		{7,8,9}
	};
	grd.Dump();
	
	/*
	grd.Length.Dump();
	grd.GetLength(0).Dump();
	for (int i = 0; i < grd.GetLength(1); i++)
	{
		for (int j = 0; j < grd.GetLength(1); j++)
		{
			grd[i,j].Dump();
		}
	}
	*/

	int pathCount = paths(grd, 2,2,0);
	pathCount.Dump();

}
public int paths(int[,] grid, int r, int c,int count){
	if(r == 0 || c == 0){
		return 1;
	}
	if(grid[r,c] == -1){
		return count;
	}
	return count = paths(grid, r-1,c,count) + paths(grid,r,c-1,count);
}

