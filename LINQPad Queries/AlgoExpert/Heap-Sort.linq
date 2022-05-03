<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	/*
		Max-Heap Sort
	*/
    int[] array =new int[] {4,1,6,2,5,3,9,7,8};
    
    HeapSort(array).Dump();
    
}
public static int[] HeapSort(int[] array){
	buildMaxHeap(array);
	array.Dump();
    
	for(int endIdx = array.Length-1; endIdx > 0; endIdx --){
		swap(0, endIdx, array);
		siftDown(0, endIdx-1, array);
	}
	
	return array;
}

private static void buildMaxHeap(int[] array)
{
	int firstParent = (array.Length - 2) / 2;
	for (int currentIdx = firstParent; currentIdx >= 0; currentIdx--)
	{
		siftDown(currentIdx, array.Length - 1, array);
	}
}

static void siftDown(int currentIdx, int endIdx, int[] heap)
{
	int childOneIdx = currentIdx * 2 +1;
	
	while(childOneIdx <= endIdx){
		int childTwoIdx = currentIdx * 2 + 2  <=endIdx ? currentIdx * 2 +2 : -1;
        
		int idxToSwap;
		if(childTwoIdx != -1 && heap[childTwoIdx] > heap[childOneIdx]){
			idxToSwap = childTwoIdx;
		}
		else{
			idxToSwap = childOneIdx;
		}
		if(heap[idxToSwap] > heap[currentIdx]){
			swap(currentIdx,idxToSwap,heap);
			currentIdx = idxToSwap;
			childOneIdx = currentIdx *2 +1;
		}
		else{
			return;
		}
	}
}

static void swap(int i, int j, int[] array)
{
	int temp = array[i];
	array[i] = array[j];
	array[j] = temp;
}


// Define other methods, classes and namespaces here
