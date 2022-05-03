/*
 * @lc app=leetcode id=657 lang=csharp
 *
 * [657] Robot Return to Origin
 */

// @lc code=start
public class Solution {
    public bool JudgeCircle(string moves) {
        int robotRow =0;
        int robotCol =0;

        foreach(char c in moves.ToCharArray()){
            switch (c)
            {
                case 'U':
                    robotRow--;
                break;
                case 'D':
                    robotRow++;
                break;
                case 'L':
                    robotCol--;
                break;
                case 'R':
                    robotCol++;
                break;
                default:
                break;

            }

        }
        return (robotCol == 0 && robotRow == 0);
    }
}
// @lc code=end

