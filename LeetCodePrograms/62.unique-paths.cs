/*
 * @lc app=leetcode id=62 lang=csharp
 *
 * [62] Unique Paths
 */

// @lc code=start
public class Solution {
    public int UniquePaths(int m, int n) {
     int[,] pathMatrix = new int[m,n];   

     for(int r =0; r<pathMatrix.GetLength(0);r++){
         for(int c =0; c<pathMatrix.GetLength(1); c++){
             if(r == 0 || c==0){
                 pathMatrix[r,c] = 1;
             }
             else{
				pathMatrix[r, c] = pathMatrix[r - 1, c] + pathMatrix[r, c - 1];	
			}
         }
     }
     return pathMatrix[m-1,n-1];
    }
}
// @lc code=end

