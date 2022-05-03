/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
public class Solution {
    public void MoveZeroes(int[] nums) {
        int st =0;
        for(int j=0;j<nums.Length; j++){
            if(nums[j] !=0){
                int temp = nums[j];
                nums[j] = nums[st];
                nums[st] = temp;
                st++;
            }
        }
    }
}
// @lc code=end

