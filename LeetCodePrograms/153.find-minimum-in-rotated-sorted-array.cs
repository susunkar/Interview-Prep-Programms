/*
 * @lc app=leetcode id=153 lang=csharp
 *
 * [153] Find Minimum in Rotated Sorted Array
 */

// @lc code=start
public class Solution {
    public int FindMin(int[] nums) {
        int low = 0;
        int high = nums.Length - 1;
        while(low < high){
            int mid = low + (high - low) / 2;
            if(nums[mid]> nums[high]){
                low = mid +1;
            }
            else{
                high = mid;
            }
        }
        return nums[low];
    }
}
// @lc code=end

