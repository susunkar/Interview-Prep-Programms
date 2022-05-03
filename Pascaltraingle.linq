<Query Kind="Program" />

void Main()
{
	GetRow(4).Dump();
	IList<int> GetRow(int number)
	{
		Dictionary<int, int[]> _dictionary = new Dictionary<int, int[]>();	
		CreatePascalList(_dictionary,number);
		
		return _dictionary[number].ToList();
	}
	void CreatePascalList(Dictionary<int, int[]> _dictionary, int number)
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

// You can define other methods, fields, classes and namespaces here