/*
 * @lc app=leetcode id=69 lang=csharp
 *
 * [69] Sqrt(x)
 */

// @lc code=start
public class Solution {
    public int MySqrt(int x) {
        if(x==0 || x==1) return x;
        long left = 1;
        long right = x;
        long res = 1;
        while (left <= right)
        {
            long mid = ( right + left)/2;
            if ((mid * mid) == x) {
                res= mid;
                break;
            }
            if ((mid * mid) < x)
            {
                res = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return (int) res;
    }
}
// @lc code=end

