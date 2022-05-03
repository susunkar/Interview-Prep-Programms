/*
 * @lc app=leetcode id=1221 lang=csharp
 *
 * [1221] Split a String in Balanced Strings
 */

// @lc code=start
public class Solution {
    public int BalancedStringSplit(string s) {
        int count =0;
        int rcount=0;
        int lcount=0;
        string t= string.Empty;
        for(int i = 0; i<s.Length; i++){
            if(s[i]== 'L') lcount++;
            if(s[i]== 'R') rcount++;

            if(lcount == rcount){
                count++;
                lcount =0;
                rcount =0;
            }
        }
        return count;
    }
}
// @lc code=end

