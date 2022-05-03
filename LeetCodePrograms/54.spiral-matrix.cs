/*
 * @lc app=leetcode id=54 lang=csharp
 *
 * [54] Spiral Matrix
 */

// @lc code=start
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> list = new List<int>();
        int RowLenth = matrix.GetLength(0);
        int ColumLength = matrix[0].Length;
        int top = 0;
        int down = RowLenth - 1;
        int left = 0;
        int right = ColumLength - 1;

        int direction = 0;
        while (top <= down && left <= right)
        {
            if (direction == 0)
            {
                //Left to Right Direction
                for (int i = left; i <= right; i++)
                {
                    list.Add(matrix[top][i]);
                }
                direction++;
                top++;
            }
            else if (direction == 1)
            {
                //Top to Down Direction
                for (int i = top; i <= down; i++)
                {
                    list.Add(matrix[i][right]);
                }
                direction++;
                right--;
            }
            else if (direction == 2)
            {
                //Right to Left Direction
                for (int i = right; i >= left; i--)
                {
                    list.Add(matrix[down][i]);
                }
                direction++;
                down--;
            }
            else if (direction == 3)
            {
                //Down to UP Direction
                for (int i = down; i >= top; i--)
                {
                    list.Add(matrix[i][left]);
                }
                direction++;
                left++;
            }
            else
            {
                direction = 0;
            }
        }
        return list;
    }
}
// @lc code=end

