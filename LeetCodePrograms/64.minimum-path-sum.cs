/*
 * @lc app=leetcode id=64 lang=csharp
 *
 * [64] Minimum Path Sum
 */

// @lc code=start
public class Solution {
    public int MinPathSum(int[][] grid) {
        int[,] minPathSumGrid = new int[grid.Length,grid[0].Length];

        for(int r =0; r<grid.Length; r++){
            for(int c =0; c<grid[r].Length;c++){
                if(c==0 && r==0){
                    minPathSumGrid[r,c] = grid[r][c];
                    continue;
                }
                if(r==0 && c!=0){
                    minPathSumGrid[r,c] = minPathSumGrid[r,c-1] +  grid[r][c];
                }
                else if(c==0 && r!=0){
                    minPathSumGrid[r,c] = minPathSumGrid[r-1,c] +  grid[r][c];
                }
                else{
                    minPathSumGrid[r,c] = Math.Min((minPathSumGrid[r-1,c] + grid[r][c]),
                                                   (minPathSumGrid[r,c-1] + grid[r][c]));
                }

            }
        }
        return minPathSumGrid[minPathSumGrid.GetLength(0)-1,minPathSumGrid.GetLength(1)-1];

    }
}
// @lc code=end

