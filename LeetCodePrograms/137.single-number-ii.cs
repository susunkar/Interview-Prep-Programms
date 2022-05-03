/*
 * @lc app=leetcode id=137 lang=csharp
 *
 * [137] Single Number II
 */

// @lc code=start
public class Solution {
    public int SingleNumber(int[] nums) {
        int SingleNumberXOR =0; 
         
        for(int i = 0 ; i<nums.Length; i++){
         SingleNumberXOR =(SingleNumberXOR^nums[i]);
        
        }
        for(int i = 0 ; i<nums.Length; i++){
         SingleNumberXOR =(SingleNumberXOR^nums[i]);
        
        }
        return SingleNumberXOR;
    }
}
// @lc code=end

