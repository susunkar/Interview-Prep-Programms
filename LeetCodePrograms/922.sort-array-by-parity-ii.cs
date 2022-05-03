/*
 * @lc app=leetcode id=922 lang=csharp
 *
 * [922] Sort Array By Parity II
 */

// @lc code=start
public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        int evenCounter = 0;
        int oddCounter =1;

        while(evenCounter<nums.Length && oddCounter<nums.Length){
            if(nums[evenCounter]%2 !=0){
                swapArray(nums,evenCounter,oddCounter);
                oddCounter+=2;
            }
            else{
                evenCounter+=2;
            }
        }
        
        return nums;

    }
    public void swapArray(int[] nums , int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
// @lc code=end

