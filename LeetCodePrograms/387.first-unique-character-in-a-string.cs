/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 */

// @lc code=start
public class Solution {
    public int FirstUniqChar(string s) {
  
        // int[] freq = new int[26];

        // for(int i =0 ; i<s.Length;i++){
        //     int decInputCahr = (int) (s.ElementAt(i) -'a');
        //     freq[decInputCahr]++;
        // }
       
        // for(int i =0 ; i< s.Length;i++){
        //      int decInputCahr = (int) (s.ElementAt(i) -'a');
        //     if(freq[decInputCahr] == 1){
        //         return i; 
        //     }
        // }
        // return -1;

         Dictionary<char,int> dict = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++) {
            if (dict.ContainsKey(s[i]))
                dict[s[i]] = -1;
            else
                dict.Add(s[i], i);
        }
        var ch = dict.Where(y => y.Value >=0).Count();
	    if(ch == 0) return -1;
        return dict.Where(y => y.Value >= 0).FirstOrDefault().Value;
    }
}
// @lc code=end

