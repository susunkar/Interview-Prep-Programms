<Query Kind="Program" />

/*
Write a function 'canSum(targetSum, numbers)' that takes in a targerSum and an 
array of numbers as arguments.

The funcation should return a boolean indicating whether or not it.
is possible to generate the targetSum using numbers from the arry.

You may use an element of the array as many time as needed.
You may assume that all input numbers are nonnegative.

canSum(7, [5,3,4,7]) -> true
						1. [3,4]
						2. [7]
canSum(7, [2,4]) -> false
*/
void Main()
{
	Dictionary<int, bool> hashResult = new Dictionary<int, bool> ();
	canSum (7,new int[]{2,3},new Dictionary<int, bool> ()).Dump();
	canSum (7,new int[]{5,3,4,7},new Dictionary<int, bool> ()).Dump();
	canSum (7,new int[]{2,4},new Dictionary<int, bool> ()).Dump();
	canSum (8,new int[]{2,3,5},new Dictionary<int, bool> ()).Dump();
	canSum (300,new int[]{7,14},hashResult).Dump();
	
}

bool canSum (int targetSum, int[] numbers, Dictionary<int,bool> hashResult)
{
	if(hashResult.ContainsKey(targetSum)) return hashResult[targetSum];
	if (targetSum == 0) return true;
	if (targetSum<0) return false;

	for (int i = 0; i < numbers.Length; i++)
	{
		int remainder = targetSum- numbers[i];
		if(canSum (remainder, numbers,hashResult)){
			hashResult.Add(targetSum, true);
			return true;
		}
	}
	hashResult.Add(targetSum, false);
	return false;
}


