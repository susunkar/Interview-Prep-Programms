<Query Kind="Program" />

void Main()
{
	var re = Combinations(new char[] { 'a','b','c'});
	re.Dump();
}


public List<List<char>> Combinations(char[] num)
{
	if (num.Length == 0) return new List<List<char>>() {new List<char>()};

	var firstEL = num[0];
	var rest = num.Skip(1).ToArray();

	var combsWithOutFirst = Combinations(rest);
	
	var combsWithFirst =  new List<List<char>>() {};

	combsWithOutFirst.ForEach(wof =>
	{
		var tem = new List<char>();
		tem.AddRange(wof);
		tem.Add(firstEL);
	
		combsWithFirst.Add(tem);
	});

	var result = combsWithOutFirst.Concat(combsWithFirst.ToList()).ToList();

	return result;
}
