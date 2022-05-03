/*
 * @lc app=leetcode id=560 lang=csharp
 *
 * [560] Subarray Sum Equals K
 */

// @lc code=start
public class Solution {
    // public int SubarraySum(int[] nums, int k) {
    //     int start =0;
    //     int next= start+1;
	// 	int sum = 0;
    //     for(int i=0; i<nums.Length; i++){
    //        sum =sum+TargetSum(nums,k,i,i+1,0,nums[i]);
    //     }
        
    //     return sum;
    // }
    // int TargetSum(int[] nums, int k, int start, int end, int count, int sum) {
        
    //     if (nums[start] == k) return count=count+1;
	// 	if (start > end || start >= nums.Length || end >= nums.Length) return count;
	// 	//if (sum > k) return 0;
		
	// 	sum += nums[end];
	// 	if (sum == k) return count=count+1;

	// 	return TargetSum(nums, k, start, end += 1, count, sum);

    // }
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> cache = new Dictionary<int, int>();
        int count =0;
        int sum =0;
        cache.Add(0,1);

        for(int i =0;i<nums.Length; i++){
            sum += nums[i];
            int need = sum -k;
            if(cache.ContainsKey(need)){
                count += cache[need];
            }
            if(!cache.ContainsKey(sum)){
                cache.Add(sum, 1);
            }
            else{
                cache[sum]++;
            }
        }
        return count;
    }
}
// @lc code=end

