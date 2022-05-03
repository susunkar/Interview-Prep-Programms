/*
 * @lc app=leetcode id=463 lang=csharp
 *
 * [463] Island Perimeter
 */

// @lc code=start
public class Solution {
    public int IslandPerimeter(int[][] grid) {
        if(grid == null) return 0;

        int perimeter = 0;
        for(int r =0; r<grid.Length; r++){
            for(int c =0; c<grid[r].Length; c++){

                if(grid[r][c]==1) {
                    perimeter=perimeter+4;
                    if(r>0 && grid[r-1][c]== 1){
                        perimeter = perimeter-2;
                    }
                    if(c>0 && grid[r][c-1]==1) {
                        perimeter = perimeter-2;
                    }
                }
            }
        }
        return perimeter;
    }
}
// @lc code=end

