/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
		Dictionary<char, int> charCount = new Dictionary<char, int>();
		foreach (char c in s.ToCharArray())
		{
			if (charCount.ContainsKey(c))
			{
				charCount[c] = charCount[c]+1;
			}
			else
			{
				charCount.Add(c, 1);
			}
		}
		foreach (char c in t.ToCharArray())
		{
			if (charCount.ContainsKey(c))
			{
				charCount[c] = charCount[c]-1;
			}
			else
			{
				return false;
			}
		}
		return charCount.All(x=>x.Value ==0);
    }
}
// @lc code=end

