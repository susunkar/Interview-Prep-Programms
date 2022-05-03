<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Random randNum = new Random();

	int[] inputarray = Enumerable
		.Repeat(0, 8)
		.Select(i => randNum.Next(1, 50))
		.ToArray();

	inputarray.Dump("Original");
	QuickSort(inputarray, 0, inputarray.Length - 1);
	inputarray.Dump("Result");

}

public void QuickSort(int[] array, int l, int h)
{
	if (l >= h)
	{
		return ;
	}
	int partitionIndex = partition(array, l,h);
	
	QuickSort(array,l,partitionIndex);
	QuickSort(array,partitionIndex+1,h);
}
public int partition(int[] array, int l, int h){
	int pivoteValue = array[l];
	int i = l;
	int j = h;

	while (i<=j)
	{
		if(array[i] <= pivoteValue){
			i++;
		}
		if(array[j] > pivoteValue){
			j--;
		}
		if (i < j)
		{
			swap(array, i, j);
		}
	}
	
	//finally swap the pivotevalue index to j index
	swap(array, l, j);
	
	return j;
}

private void swap(int[] array, int i, int j)
{
	
	int temp = array[j];
	array[j]= array[i];
	array[i] = temp;
	
}
// Define other methods, classes and namespaces here