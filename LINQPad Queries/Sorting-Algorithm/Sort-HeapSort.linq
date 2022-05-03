<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	int[] input = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14};
	
	BuildHeap(input);

	input.Dump();
	HeapSort(input);
	input.Dump();
}

public void HeapSort (int[] inputArray){
	
	BuildHeap(inputArray);
	for(int i = inputArray.Count()-1 ;i >=0 ; i--){
		int temp = inputArray[0];
		inputArray[0] = inputArray[i] ;
		inputArray[i] = temp;
		Heapify(inputArray, 0,i);
	}
}
public void BuildHeap(int[] inputArray){
	
	int lenght = inputArray.Count();
	
	for (int i = (lenght/2-1); i>=0; i--){
		Heapify(inputArray, i, lenght);
	}
}

private void Heapify(int[] inputArray, int idx, int maxIdx)
{
	int left = 2 * idx + 1;
	int right = 2 * idx + 2;
	
	int largest;
	if(left < maxIdx && inputArray[left] > inputArray[idx]){
		largest = left;
	}
	else largest = idx;
	
	if(right < maxIdx && inputArray[right] > inputArray[largest]){
		largest = right;
	}
	
	if(largest != idx){
		int temp = inputArray[largest];
		inputArray[largest] =inputArray[idx];
		inputArray[idx] = temp;
		Heapify(inputArray, largest, maxIdx);
	}
}


// Define other methods and classes here