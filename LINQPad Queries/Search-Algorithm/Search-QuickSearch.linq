<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	int[] primes = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
		41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97,100};

	var result = doSearch(primes, -100);
	
	result.Dump("Index");
	
	if(result >-1)
		primes[result].Dump("Search Value");
}


public int doSearch(int[] array, int targetValue)
{
	var min = 0;
	var max = array.Count() - 1;
	var guess = (min + max) / 2;

	while (min <= max)
	{
		guess = (min + max) / 2;

		if (array[guess] == targetValue)
		{
			return guess;
		}
		if (array[guess] > targetValue)
		{
			max = guess - 1;
		}
		else if (array[guess] < targetValue)
		{
			min = guess + 1;
		}
	}
	return -1;
}


// Define other methods and classes here
