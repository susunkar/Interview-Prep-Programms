/*
 * @lc app=leetcode id=442 lang=csharp
 *
 * [442] Find All Duplicates in an Array
 */

// @lc code=start
public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
       List<int> duplicates = new List<int>();
        for(int i = 0; i<nums.Length; i++){
        	int idx = Math.Abs(nums[i]) -1;   
			if(nums[idx]<0) {
				duplicates.Add(Math.Abs(nums[i]));
			}
			else{
				nums[idx] *=-1; 
			}
        }
        return duplicates;
    }
}
// @lc code=end

