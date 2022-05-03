/*
 * @lc app=leetcode id=56 lang=csharp
 *
 * [56] Merge Intervals
 */

// @lc code=start
public class Solution {
    public int[][] Merge(int[][] intervals) {
       Array.Sort(intervals, (a, b) => Comparer.Default.Compare(a[0], b[0]));
		List<int[]> merged = new List<int[]>();

		foreach (int[] arr in intervals)
		{
			
			if (merged.Count == 0 || IsInputsAreIN(merged.Last()[0] , merged.Last()[1] ,arr[0], arr[1])){
				merged.Add(arr);
			}
			else {
				merged.Last()[0] = Math.Min(merged.Last()[0], arr[0]);
				merged.Last()[1] = Math.Max(merged.Last()[1], arr[1]);
			}
			//arr.Dump();
			//merged.Last()?.Dump();
		}
		return merged.ToArray();
    }
    bool IsInputsAreIN(int st, int ed, int st1, int ed1)
	{
		//Console.WriteLine($"{st} {ed} {st1} {ed1}");
		//true for new entry
		if(st1>ed) return true;
		else if( ed1<st) return true;
		return false;
		
		//false for merge
		
	}
}
// @lc code=end

