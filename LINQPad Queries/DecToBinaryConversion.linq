<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	int num = 300;
	string rem = "";
	while (num > 0)
	{
		var r = num % 2;
		rem += r.ToString();
		num = num / 2;
	}
	rem += num.ToString();
	string binary = "";
	for (int i = rem.Length - 1; i >= 0; i--)
	{
		binary += rem[i];
	}
	binary = Regex.Replace(binary, ".{4}", "$0\t");
	binary.Dump();
}

// Define other methods and classes here
