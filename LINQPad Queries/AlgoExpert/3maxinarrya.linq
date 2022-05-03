<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

public class Program
{
	public static int[] FindThreeLargestNumbers(int[] array)
	{
		// Write your code here.
		int[] r = new int[3] {int.MinValue,int.MinValue,int.MinValue};
		
		foreach(int num in array){
			updateResult(r,num);
		}
		return r;
	}

	private static void updateResult(int[] r, int num)
	{
		if(num > r[2]){
			shiftup(r,num, 2);
		}
		else if(num > r[1])
		{
			shiftup(r,num, 1);
		}
		else if(num > r[0])
		{
			shiftup(r,num, 0);
		}
	}

	private static void shiftup(int[] r, int num, int idx)
	{
		for(int i =0; i<=idx; i++)
		{
			if(i==idx)
			{
				r[i] = num;
			}
			else {
				r[i] = r[i+1];
			}
		}
	}
}
void Main()
{
	int[] a = new int[] { 141,1,17,-7,-17,-27,18,541,8,7,7};
	//int[] a = new int[] { 10,5,9,10,12};
	var r = Program.FindThreeLargestNumbers(a);
	r.Dump();
}

// Define other methods, classes and namespaces here