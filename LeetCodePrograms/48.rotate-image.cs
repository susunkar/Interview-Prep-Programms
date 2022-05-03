/*
 * @lc app=leetcode id=48 lang=csharp
 *
 * [48] Rotate Image
 */

// @lc code=start
public class Solution {
    public void Rotate(int[][] matrix) {
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
        
    }
    void Swapp(ref int[][] matrix, int r, int c)
	{
		int tem = matrix[r][c];
		matrix[r][c] = matrix[c][r];
		matrix[c][r] = tem;
	}
}
// @lc code=end

