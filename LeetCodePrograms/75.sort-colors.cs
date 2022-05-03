/*
 * @lc app=leetcode id=75 lang=csharp
 *
 * [75] Sort Colors
 */

// @lc code=start
public class Solution {
    public void SortColors(int[] nums) {
        
		int startIdx = 0;
		int endIdx = nums.Length-1;
		int currentIdx = startIdx;

		while(currentIdx<=endIdx && startIdx<endIdx){
			if(nums[currentIdx] ==0){
				//swap currentIdx value with startIdx
				SwapValue(nums,currentIdx,startIdx);
					startIdx++;
					currentIdx++;
			}
			else if(nums[currentIdx] == 2 ){
				//swap currentIdx value with endIdx
				SwapValue(nums,currentIdx,endIdx);
				endIdx--;
			}
			else{
				currentIdx++;
			}
		}
		
    }
	public void SwapValue(int[] nums, int xId, int yId){
		int temp = nums[xId];
		nums[xId] = nums[yId];
		nums[yId] = temp;
	}
}
// @lc code=end

