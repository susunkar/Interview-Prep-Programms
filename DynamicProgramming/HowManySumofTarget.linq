<Query Kind="Program" />

/*
write a funcation howSum(targetSum, numbers) that takes in a targetSum and an array of numbers as arguments.

The function should return an array containing any combination of elements that add up to exactly the rargetSum. If there is no combination that adds up to 
the targetSum, then return null.

If there are multiple combinations possible, you may return any single one.
howsum(7,[5,3,4,7]) -> [[3,4], [7]]
howsum(8,[2,3,5]) -> [[3,5], [3,3,2],[2,2,2,2]]
howsum(7,[2,4]) -> null
howsum(0,[1,2,3]) -> []



*/
void Main()
{
	//Dictionary<int, List<List<int>>> hashMemo1 = new Dictionary<int, List<List<int>>>();
	//howSum (7,new int[]  {2,3},hashMemo1).Dump();
	//
//	Dictionary<int, List<List<int>>> hashMemo2 = new Dictionary<int, List<List<int>>>();
//	howSum (7, new int[] { 5, 3, 4,7 },hashMemo2).Dump();
//
	//	Dictionary<int, List<List<int>>> hashMemo3 = new Dictionary<int, List<List<int>>>();
	//	howSum (7, new int[] { 2, 4 },hashMemo3).Dump();
	//	
	//	Dictionary<int, List<List<int>>> hashMemo4 = new Dictionary<int, List<List<int>>>();
	//	howSum (8, new int[] { 2, 3,5 },hashMemo4).Dump();
	//	
	Dictionary<int, List<List<int>>> hashMemo5 = new Dictionary<int, List<List<int>>>();
	   howSum (300, new int[] { 7,14},hashMemo5).Dump();

}


List<List<int>>? howSum (int target, int [] numbers, Dictionary<int, List<List<int>>> hashMemo)
{
	if (hashMemo.ContainsKey (target)) return hashMemo [target];
	if (target == 0) return new List<List<int>>();
	if (target < 0) return null;

	foreach (var element in numbers)
	{
		var result = howSum (target - element, numbers, hashMemo);

		if (result != null)
		{
			result.Add (new List<int>() { element });
			hashMemo.Add (target, result);
			return hashMemo [target];
		}
	}
	hashMemo.Add (target, null);
	return hashMemo [target];
}

