/*
 * @lc app=leetcode id=867 lang=csharp
 *
 * [867] Transpose Matrix
 */

// @lc code=start
public class Solution {
    public int[][] Transpose(int[][] matrix) {
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
// @lc code=end

