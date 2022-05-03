/*
 * @lc app=leetcode id=167 lang=csharp
 *
 * [167] Two Sum II - Input Array Is Sorted
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int low = 0;
        int high = numbers.Length -1;

        while(low<high){
            int needed = numbers[low] + numbers[high];

            if(needed == target){
                return new int[] {low+1, high+1};
            }
            if(needed < target){
                low ++;
            }
            else {
                high --;
            }
        }
        return null;
    }
}
// @lc code=end

