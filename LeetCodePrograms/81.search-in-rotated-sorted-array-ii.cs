/*
 * @lc app=leetcode id=81 lang=csharp
 *
 * [81] Search in Rotated Sorted Array II
 */

// @lc code=start
public class Solution {
    public bool Search(int[] nums, int target) {
   
        if (nums == null || nums.Length == 0) return false;
		
		int start = 0;
		int end = nums.Length - 1;

		while (start <= end)
		{
			int mid = start + (end-start)/2;

			if (target == nums[mid])
			{
				return true;
			}
			//Normal
			if (nums[start]<nums[mid])
			{
				if (target < nums[start] || target > nums[mid])
				{
					start = mid+1;
				}
				else
				{
					end = mid - 1;
				}
			}
			else if (nums[start] > nums[mid]){
					if (target < nums[mid] || target > nums[end])
					{
						end = mid - 1;
					}
					else
					{
						start = mid + 1;
					}
				}
				else{
					start++;
				}
		}
		return false;
    }
}
// @lc code=end

