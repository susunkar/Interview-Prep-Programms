/*
 * @lc app=leetcode id=724 lang=csharp
 *
 * [724] Find Pivot Index
 */

// @lc code=start
public class Solution {
    public int PivotIndex(int[] nums) {
       int total = 0;
       for(int i=0; i<nums.Length; i++){
           total += nums[i];
       }

       int left = 0;
       for(int i=0; i<nums.Length;i++){
           if(i>0) left+=nums[i-1];
           if(total - left - nums[i] == left){
               return i;
           }
       }
       return -1;
    }
}
// @lc code=end

