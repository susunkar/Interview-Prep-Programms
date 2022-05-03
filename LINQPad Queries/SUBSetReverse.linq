<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	List<int> inpuSet = new List<int>{1,2,3,4};
	List<List<int>> subSet = new List<List<int>>();
	
	populateSubSets(subSet,inpuSet);
	
	foreach (var set in subSet)
	{
		
		foreach	(var e in set){
			Console.Write("{0}", e);
		}
		Console.WriteLine();
	}
}

public void populateSubSets<T>(List<List<T>> subSetList, List<T> inputSet){
	
	if(inputSet.Count==0)
	{
		subSetList.Add(new List<T>());
		return;
	}
	
	T currentNum = inputSet[0];
	inputSet.Remove(currentNum);
	
	populateSubSets(subSetList,inputSet);
	
	List<List<T>> tempList = new List<List<T>>();
	tempList.AddRange(subSetList);
	
	
	foreach (var subset in tempList)
	{
		List<T> newSubList = new List<T>();
		newSubList.AddRange(subset);
		newSubList.Add(currentNum);
		
		subSetList.Add(newSubList);
	}
	
	
}
// Define other methods and classes here
