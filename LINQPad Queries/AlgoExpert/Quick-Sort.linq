<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	/*
		Quick short
        Best: O(n log(n)) time | O(n log(n)) space
        Average: O(n log(n)) time | O(n log(n)) space
        Worst: O(n^2) time | O(log(n)) space
	*/
	int[] array = new int[] {8,5,2,9,5,6,3};
	QuickSort(array).Dump();
}
public static int[] QuickSort(int[] array){
	QuickSortHelper(array, 0, array.Length-1);
	return array;
}
public static void QuickSortHelper(int[] array, int startIdx, int endIdx)
{
	if (startIdx >= endIdx)
	{
		return;
	}
	int pivotIdx = startIdx;
	int leftIdx = startIdx + 1;
	int rightIdx = endIdx;

	while (rightIdx >= leftIdx)
	{
		if (array[leftIdx] > array[pivotIdx] && array[rightIdx] < array[pivotIdx])
		{
			swap(leftIdx, rightIdx, array);
		}
		if (array[leftIdx] <= array[pivotIdx])
		{
			leftIdx += 1;
		}
		if (array[rightIdx] >= array[pivotIdx])
		{
			rightIdx -= 1;
		}
	}
	swap(pivotIdx, rightIdx, array);

	bool leftSubarrayIsSmaller = (rightIdx - 1 - startIdx) < (endIdx - (rightIdx + 1));

	if (leftSubarrayIsSmaller)
	{
		QuickSortHelper(array, startIdx, rightIdx - 1);
		QuickSortHelper(array, rightIdx + 1, endIdx);
	}
	else
	{
		QuickSortHelper(array, rightIdx + 1, endIdx);
		QuickSortHelper(array, startIdx, rightIdx - 1);
	}
}

static void swap(int leftIdx, int rightIdx, int[] array)
{
	int temp = array[rightIdx];
	array[rightIdx] = array[leftIdx];
	array[leftIdx] = temp;
}
// Define other methods, classes and namespaces here
