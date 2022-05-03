/*
 * @lc app=leetcode id=451 lang=csharp
 *
 * [451] Sort Characters By Frequency
 */

// @lc code=start

public class Solution {
    public string FrequencySort(string s) {
    
    Dictionary<char,string> frqCount = new Dictionary<char, string>();
    StringBuilder stringbuilder = new StringBuilder();

    foreach(char c in s.ToCharArray()){
        if(frqCount.ContainsKey(c)){
            frqCount[c]=frqCount[c]+c.ToString();
        }
        else{
            frqCount.Add(c,c.ToString());
        }
    }
    foreach(var c in frqCount.OrderByDescending(x=>x.Value.Count())){
        stringbuilder.Append(c.Value);
    }

    return stringbuilder.ToString();
        
    }
}
// @lc code=end

