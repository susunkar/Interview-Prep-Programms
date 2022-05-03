/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        int[] result = new int[2];
        for(int i = 0; i < nums.Length; i++){
            int needed = target - nums[i];

            if(d.ContainsKey(needed)){
                result[0] = d[needed];
                result[1] = i;
                return result;
            }
            else if (!d.ContainsKey(nums[i])) // handles duplicates in array
            {
                d.Add(nums[i], i);
            }
        }
        return result;
    }
}
// @lc code=end

