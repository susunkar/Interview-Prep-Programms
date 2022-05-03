<Query Kind="Program" />

void Main()
{
	var re = Permutations(new char[] { 'a','b','c'});
	re.Dump();
}


public List<List<char>> Permutations(char[] num)
{
	if (num.Length == 0) return new List<List<char>>() { new List<char>() {}};

	var firstEL = num[0];
	var rest = num.Skip(1).ToArray();

	var permWithOutFirst = Permutations(rest);

	var allPermutations = new List<List<char>>() ;

	permWithOutFirst.ForEach(wof =>
	{
		for (int i = 0; i <=wof.Count; i++)
		{
			
			var first = wof.Take(i).ToList();
			var last= wof.Skip(i).ToList();

			var r = first.Concat(new List<char>() { firstEL}).ToList().Concat(last).ToList();
			allPermutations.Add(r);
		}
		
	});

	//var result = combsWithOutFirst.Concat(combsWithFirst.ToList()).ToList();

	return allPermutations;
}
