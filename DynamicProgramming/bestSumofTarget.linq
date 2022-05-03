<Query Kind="Program" />

/*
Write a function bestSum(targetSum, numbers) that takes in a targetSum and an array of numbers as arguments.

The function should return an array containing the Shortest comination of numbers that are up to exactly the targetSum.

if there is a  tie for the shortest combination, you may return any one of the shortest.

bestSum(7,[5,3,4]) -> [7]
				   -> [3,4] 
				   -> [7]
bestSum(8,[2,3,5]) -> [3,5]
				   -> [2,2,2,2] 
				   -> [2,3,2]
				   -> [3,5]
				   
*/
void Main()
{
	bestSum (7, new int[] { 5, 3, 4,7}).Dump();//[7]
	bestSum (8, new int[] { 2, 3, 5 }).Dump();
	bestSum (8, new int[] { 0, 4, 5 }).Dump();
}

List<List<int>>? bestSum (int target, int [] numbers)
{
	if (target < 0) return null;

	if(target == 0) return new List<List<int>>();
	
	List<List<int>>? shortestCombination = null;
	foreach (var cur in numbers)
	{

		var remainder = target - cur;
		if (target == remainder) break;//edge case 

		var result = bestSum (remainder, numbers) ;
		if (result != null)
		{
			result.Add (new List<int>() { cur });
			if(shortestCombination == null ||  result.Count <  shortestCombination.Count){
				shortestCombination = result;
			}
		}
	}
	return shortestCombination;
}

