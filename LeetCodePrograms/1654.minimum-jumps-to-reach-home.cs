/*
 * @lc app=leetcode id=1654 lang=csharp
 *
 * [1654] Minimum Jumps to Reach Home
 */

// @lc code=start
public class Solution
{
    public int MinimumJumps(int[] forbidden, int a, int b, int x)
    {
        HashSet<int> forbiddenPosition = new HashSet<int>();
        for (int i = 0; i < forbidden.Length; i++)
        {
            forbiddenPosition.Add(forbidden[i]);
        }
        HashSet<int> visitedPosition = new HashSet<int>();
        int currentposition = 0;
        int forward = 0;
        while (!forbiddenPosition.Contains(currentposition) && currentposition != x && !visitedPosition.Contains(currentposition))
        {
            int temp = currentposition + a;
            if (!forbiddenPosition.Contains(temp) && temp <= forbiddenPosition.Max())
            {
                forward++;
                currentposition = temp;
                visitedPosition.Add(temp);
            }
            else
            {
                temp = currentposition - b;
                if (!forbiddenPosition.Contains(temp) && temp <= forbiddenPosition.Max())
                {
                    currentposition = temp;
                    forward++;
                    visitedPosition.Add(temp);
                }
            }
            if (currentposition == x)
            {
                return forward;
            }
        }
        if (currentposition == x)
        {
            return forward;
        }
        return -1;
    }
}
// @lc code=end

