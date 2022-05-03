/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution {
    public int Reverse(int x) {
        long result = 0;
        while(x != 0){
            result = x%10 +(result *10);
            x= x/10;
            if(result > int.MaxValue || result < int.MinValue) return 0;
        }
        return (int) result;
    }
}
// @lc code=end

