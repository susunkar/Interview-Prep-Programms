<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	//Lonley Integer element in the array
	//tip is conver the integer into binary and do XOR operation

	int[] array = {2,4,5,2,5,1,3,4,1};
	int sum = 0;
	foreach (var element in array)
	{
		sum ^= element; //XOR
	}
	sum.Dump();
}

// Define other methods and classes here
