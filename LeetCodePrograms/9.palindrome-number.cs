/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        int rev =0;
        int copy = x;
        while(x>0){
            rev = (rev*10)+ (x %10 );
            x= x /10;
        }
        return(rev == copy);
    }
}
// @lc code=end

