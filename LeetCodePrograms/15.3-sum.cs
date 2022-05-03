/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

// @lc code=start
Solution s = new Solution();
s.ThreeSum(new int[]{2,3,5});

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
       if (nums.Length <= 1 || nums == null)
		{
			return new List<IList<int>>();
		}

		List<IList<int>> result = new List<IList<int>>();
		Array.Sort(nums);

		int i = 0;

		int lIdx = i + 1;
		int rIdx = nums.Length-1;

		while (i < nums.Length)
		{
			if (i>0 && nums[i] == nums[i-1])
			{
				i+=1;
				continue;
			}
			lIdx = i + 1;
			rIdx = nums.Length - 1;
			while(lIdx<rIdx){
				int _threeSum = nums[i] + nums[lIdx] + nums[rIdx];
				if(_threeSum>0){
					rIdx--;
				}
				else if(_threeSum<0){
					lIdx++;
				}
				else
				{
					result.Add(new List<int> { nums[i], nums[lIdx], nums[rIdx] });
					lIdx++;
					while (lIdx > 0 && nums[lIdx] == nums[lIdx - 1] && lIdx < rIdx)
					{
						lIdx++;
					}
					if(lIdx>=rIdx ){
						break;
					}
				}
			}
			i+=1;
		}
		return result;
    }
}
// @lc code=end

