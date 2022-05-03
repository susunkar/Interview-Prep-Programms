<Query Kind="Program">
  <Output>DataGrids</Output>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

public class Program
{
	public static int[] BubbleSort(int[] array)
	{
		// Write your code here.
		bool IsSorted = false;
		int c = 1;
		for(int i=0 ; i<array.Length && IsSorted == false ; i++)
		{
			IsSorted = true;
			c +=1;
				for (int j = 0; j <array.Length-1-i; j++)
				{
					c +=1;
					if(array[j] > array[j+1])
					{
						var temp = array[j+1];
						array[j+1] = array[j];
						array[j] = temp;
						IsSorted = false;
					}
				}
				
		}
		c.Dump();
		return array;
	}
}

void Main()
{
	//int[] array = new int[] {8,5,2,9,5,6,3};
	int[] array = new int[] {2,3,5,5,6,8,9};
	var r = Program.BubbleSort(array);
	r.Dump();
}

// Define other methods and classes here
