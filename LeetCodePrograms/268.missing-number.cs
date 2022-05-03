/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 */

// @lc code=start
public class Solution {
    public int MissingNumber(int[] nums) {
        int sumNaturals = (nums.Length * (nums.Length + 1))/2;
        int arraySum=0;
        for (int i = 0; i < nums.Length; i++){
            arraySum += nums[i];
        }
        return sumNaturals - arraySum;
    }
}
// @lc code=end

