/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 */

// @lc code=start
public class Solution {
    public int NumIslands(char[][] grid) {
        int IsLandsCountter = 0;
        for(int r=0; r<grid.Length; r++){
            for(int c=0; c<grid[r].Length; c++){
                if(grid[r][c]=='1'){
                    IsLandsCountter ++;
                    MarkIsLands(grid, r, c);
                }
            }
        }
        return IsLandsCountter;
    }
    public void MarkIsLands(char[][] Lands, int r, int c){

        if(r<0 || c<0 || r>=Lands.Length || c>=Lands[r].Length || Lands[r][c] != '1') return ;

        Lands[r][c] ='2';
        MarkIsLands(Lands, r-1, c);
        MarkIsLands(Lands, r, c-1);
        MarkIsLands(Lands, r+1, c);
        MarkIsLands(Lands, r, c+1);
    }
}
// @lc code=end

