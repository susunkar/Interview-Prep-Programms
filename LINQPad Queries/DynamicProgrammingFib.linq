<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	
	//RecurciveFibNumber(5).Dump();
	//RecurciveFibNumber(15).Dump();
	//RecurciveFibNumber(40).Dump();
	//RecurciveFibNumber(55).Dump();
	
	DynamicProgram dy = new DynamicProgram();
	dy.DynamicFibNumber(10).Dump();
	dy.DynamicFibNumber(20).Dump();
	dy.DynamicFibNumber(30).Dump();
	dy.DynamicFibNumber(31).Dump();
	
	for (int i = 0; i < dy.fibSeriesList.Count; i++)
	{
		Console.WriteLine("{0} : {1}", i, dy.fibSeriesList[i]);
	}
}
public class DynamicProgram
{
	public List<int> fibSeriesList = new List<int>() {1,1};
	
	public int RecurciveFibNumber(int num)
	{
		if (num == 0 || num == 1) return 1;

		return RecurciveFibNumber(num - 1) + RecurciveFibNumber(num - 2);
	}

	public int DynamicFibNumber(int num)
	{
		if (num == 0 || num == 1)
		{
			return 1;
		}
		
		if(num < fibSeriesList.Count())
			return fibSeriesList[num];
					
		var total = DynamicFibNumber(num - 1) + DynamicFibNumber(num - 2);
		fibSeriesList.Add(total);
		return total;
	}
}
// Define other methods and classes here
