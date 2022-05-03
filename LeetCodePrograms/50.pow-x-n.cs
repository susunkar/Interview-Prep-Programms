/*
 * @lc app=leetcode id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution {
    public double MyPow(double x, int n) {
       if (n == 0) return 1;
    
        var half = MyPow(x, n / 2);
        if (n % 2 == 0) 
            return half * half;
        else if (n > 0) 
            return half * half * x;
        else 
            return half * half / x;
    }
}
// @lc code=end

