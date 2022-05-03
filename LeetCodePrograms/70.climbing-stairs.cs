/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */

// @lc code=start

public class Solution {
    
    System.Collections.Hashtable  memo = new  Hashtable();
    public int ClimbStairs(int n) {
        if(memo.Contains(n)) return (int) memo[n];
        if(n<=1) return 1;
        memo.Add(n,ClimbStairs(n-1) + ClimbStairs(n-2));
        return (int) memo[n];
    }
}
// @lc code=end

