<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	Random randNum = new Random();

	int[] inputarray = Enumerable
		.Repeat(0, 150000)
		.Select(i => randNum.Next(1, 15000))
		.ToArray();
		
	BobbleSort(ref inputarray);
	inputarray.Dump();


}
/*
it is a stable sort
it is in place
it is adaptive
O(N^2)
	
*/
public void BobbleSort(ref int[] arr)
{

	for (int i = 0; i < arr.Length; i++)
	{
		bool swapped = false;
		for (int j = arr.Length - 1; j > i; j--)
		{
				if (arr[j] < arr[j - 1])
				{
					swap(ref arr, j, j - 1);
					swapped = true;
				}
		}
		if (swapped==false)
		{
			break;
		}
	}
}
public void swap(ref int[] arr,int m, int n){
	var temp = arr[m];
	arr[m]= arr[n];
	arr[n] = temp;
}
// Define other methods and classes here