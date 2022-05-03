/*
 * @lc app=leetcode id=187 lang=csharp
 *
 * [187] Repeated DNA Sequences
 */

// @lc code=start
public class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        HashSet<string> seen = new HashSet<string>();
        HashSet<string> repeated = new HashSet<string>();
        for (int i = 0; i < s.Length - 9; i++)
        {
            string temp = s.Substring(i, 10);

            if (!seen.Contains(temp))
            {
                seen.Add(temp);
            }
            else
            {
                repeated.Add(temp);
            }
        }
        return repeated.ToList();
    }
}
// @lc code=end

