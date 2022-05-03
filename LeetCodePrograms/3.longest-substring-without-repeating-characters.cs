/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int i =0;
        int j = 0;
        int max = 0;
        HashSet<char> charSet = new HashSet<char>();
        while(j<s.Length){
            char c = s[j];
            if(!charSet.Contains(c)){
                charSet.Add(c);
                j++;
                max = Math.Max(max,charSet.Count);
            }
            else {
                charSet.Remove(s[i]);
				i++;
            }
        }
        return max;
    }
}
// @lc code=end

