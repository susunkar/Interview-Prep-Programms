<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	/*
		Find the subarray, which need to sort then entry array will sort it self
		array = [1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19]
		index    0, 1, 2, 3, 4,  5,  6, 7,  8, 9, 10, 11, 12 
		
		output : [3, 9] index
	*/
	int[] array = new int[]{1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19};
	
	SubarraySort(array).Dump();
}

public static int[] SubarraySort (int[] array){
	int minOutOfOrder = Int32.MaxValue;
	int maxOutOfOrder = Int32.MinValue;
	
	for(int i = 0; i<array.Length; i++){
		
		int num = array[i];
		
		if(isOutOfOrder(i, num, array)){
			minOutOfOrder = Math.Min(minOutOfOrder, num);
			maxOutOfOrder = Math.Max(maxOutOfOrder, num);
		}
	}
	if(minOutOfOrder == Int32.MaxValue){
		return new int[] {-1,-1};
	}
	
	int subarrayLeftIdx = 0;
	while(minOutOfOrder >= array[subarrayLeftIdx]){
		subarrayLeftIdx++;
	}

	int subarrayRightIdx = array.Length-1;
	while (maxOutOfOrder <= array[subarrayRightIdx])
	{
		subarrayRightIdx--;
	}

	return new int[] {subarrayLeftIdx, subarrayRightIdx};

}

static bool isOutOfOrder(int i, int num, int[] array)
{
	if (i == 0)
	{
		return num > array[i + 1];
	}
	if (i == array.Length-1){
		return num < array[i-1];
	}
	
	return num > array[i+1] || num < array[i-1];
}


// Define other methods, classes and namespaces here
