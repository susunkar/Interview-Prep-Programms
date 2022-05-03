/*
 * @lc app=leetcode id=1046 lang=csharp
 *
 * [1046] Last Stone Weight
 */

// @lc code=start
public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        if(stones.Length == 1) return stones[0];

        List<int> sortStones = new List<int>();

        sortStones.AddRange(stones);
        sortStones.Sort();
        int yId = sortStones.Count - 1;
        int xId = yId-1;
	
        while(xId>=0 && xId<yId && sortStones.Count>0)
        {
            int x = sortStones[xId];
            int y = sortStones[yId];
            if (x == y)
            {
                sortStones.RemoveAt(xId);
                sortStones.RemoveAt(yId-1);
            }
            else if (x < y)
            {
                sortStones[yId] = y - x;
                sortStones.RemoveAt(xId);
                sortStones.Sort();
            }
            yId = sortStones.Count - 1;
            xId = yId - 1;
        }
        return sortStones.FirstOrDefault();
    }
}
// @lc code=end

