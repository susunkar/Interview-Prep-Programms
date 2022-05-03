<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	AddThreeNumber();
}
static void AddThreeNumber()
{
	int[] array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
	List<int[]> o = new List<int[]> ();
	Array.Sort(array); //Note: with out sort we can't achive the out put
	int targetSum = 0;
	
	for (int i =0 ; i<array.Length-1; i++)
	{
		int l = i+1;
		int r = array.Length-1;
		int x = array[i];
		while(l<r){
			if ((x + array[l] + array[r]) == targetSum)
			{
				o.Add(new int[] { array[i], array[l], array[r] });
				l++;
				r--;
			}
			else if ((x + array[l] + array[r]) < targetSum)
			{
				l++;
			}
			else if ((x + array[l] + array[r]) > targetSum)
			{
				r--;
			}
			
		}
	}
	foreach (var i in o)
	{
		for(var j=0; j<i.Length ;j++)
		{
			Console.Write($"{i[j]} ");
		}
		Console.WriteLine("");
	}
	
}

// Define other methods, classes and namespaces here
