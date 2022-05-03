/*
 * @lc app=leetcode id=119 lang=csharp
 *
 * [119] Pascal's Triangle II
 */

// @lc code=start
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        Dictionary<int, int[]> _dictionary = new Dictionary<int, int[]>();	
		CreatePascalList(_dictionary,rowIndex);
		
		return _dictionary[rowIndex].ToList();
    }
    public void CreatePascalList(Dictionary<int, int[]> _dictionary, int number)
	{
		for (int level = 0; level <= number; level++)
		{
			if (level == 0)
			{
				_dictionary.Add(level, new int[] { 1 });
				continue;
			}
			else if (level == 1)
			{
				_dictionary.Add(level, new int[] { 1, 1 });
				continue;
			}

			for (int i = 0; i <= level; )
			{
				if (i == 0)
				{
					_dictionary[level] = new int[number + 1];
					_dictionary[level][0] = 1;
					_dictionary[level][1] = level;
					i += 2;
				}
				else if (i == level)
				{
					_dictionary[level][i] = 1;
					i++;
				}
				else{
					_dictionary[level][i] = _dictionary[level-1][i-1] + _dictionary[level-1][i];
					i++;
				}
			}
		}
    }

}
// @lc code=end

