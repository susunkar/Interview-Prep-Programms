/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null) return string.Empty;

        string lcm = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(lcm) != 0)
            {
                lcm = lcm.Substring(0, lcm.Length - 1);
            }
        }
        
        return lcm;
    }
}
// @lc code=end

