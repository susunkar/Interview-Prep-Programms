/*
 * @lc app=leetcode id=704 lang=csharp
 *
 * [704] Binary Search
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {

        if(nums == null || nums.Length == 0) return -1;

        int l = 0;
        int r = nums.Length-1;
        
        while(l<=r){
            int mid = (l+r)/2;
            if(nums[mid]==target) return mid;
            if(nums[mid]<target) l = mid+1;
            if(nums[mid]>target) r = mid-1;
        }
        return -1;
    }
}
// @lc code=end

