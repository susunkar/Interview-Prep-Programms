/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution {
    public int MaxSubArray(int[] nums) {

      
        if(nums== null ) return 0;
        if(nums.Length == 1) return nums[0];
        int curentSum = 0;
        int maxSum = int.MinValue;
        for(int i=0; i<nums.Length ; i++)
        {
            curentSum += nums[i];
            if(curentSum > maxSum ) {
                maxSum = curentSum;
            }
           
            if(curentSum < 0){
               curentSum = 0;
            }
        }
        return maxSum;
    }
}
// @lc code=end

