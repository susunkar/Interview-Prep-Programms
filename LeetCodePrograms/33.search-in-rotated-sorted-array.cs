/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
        if (nums == null || nums.Length == 0) return -1;
		
		int start = 0;
		int end = nums.Length - 1;

		if (nums.Length == 1)
		{
			if (nums[0] == target) return 0;
			else return -1;
		}

		while (start <= end)
		{
			int mid = start + (end-start)/2;

			if (target == nums[mid])
			{
				return mid;
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
		return -1;
    }
}
// @lc code=end

