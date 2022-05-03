<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	List<int> inpuSet = new List<int>{1,2,3,4};
	List<List<int>> subSet = new List<List<int>>();
	
	populateSubSets(subSet,inpuSet);
	subSet.Dump();
	subSet.Count.Dump();
}

public void populateSubSets(List<List<int>> subSetList, List<int> inputSet){
	
	if(inputSet.Count==0)
	{
		subSetList.Add(new List<int>());
		return;
	}
	
	int currentNum = inputSet[0];
	inputSet.Remove(currentNum);
	
	
	
	populateSubSets(subSetList,inputSet);
	
	List<List<int>> tempList = new List<List<int>>();
	tempList.AddRange(subSetList);
	
	
	
	foreach (var subset in tempList)
	{
		List<int> newSubList = new List<int>();
		newSubList.AddRange(subset);
		newSubList.Add(currentNum);
		
		subSetList.Add(newSubList);
	}
	
	
}
// Define other methods and classes here
