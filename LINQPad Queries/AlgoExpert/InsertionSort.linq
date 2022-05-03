<Query Kind="Program">
  <Output>DataGrids</Output>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

public class Program
{
	public static int[] InsertionSort(int[] array)
	{
		int c =1;
		for (int i = 0; i < array.Length; i++)
		{
			c +=1;
			for	(int j=i; j>0; j--){
			c +=1;
				if(array[j] <array[j-1])
				{
					int temp = array[j-1];
					array[j-1] = array[j];
					array[j] = temp;
					
				}
			}
		}
		c.Dump();
		return array;
	}
}

void Main()
{
	int[] array = new int[] {8,5,2,9,5,6,3};
	var r = Program.InsertionSort(array);
	r.Dump();
}

// Define other methods and classes here
