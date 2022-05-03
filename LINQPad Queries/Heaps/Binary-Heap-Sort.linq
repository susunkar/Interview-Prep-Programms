<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	int[] input = new int[]  {56,17,12,5,14,9,4,2,1,10,6};
	Heap _hp = new Heap();
	_hp.HeapSort(input);
	
	input.Dump();
}

public class Heap
{
	public int getLeftChildIndex(int parentIndex, int endIndex)
	{
		var _leftChildIndex = parentIndex * 2 + 1;
		if(_leftChildIndex >endIndex)
		{
			return -1;
		}
		return _leftChildIndex;
	}
	
	public int getRightChildIndex(int parentIndex, int endIndex)
	{
		var _rightChildIndex = parentIndex * 2 + 2;
		if(_rightChildIndex>endIndex)
		{
			return -1;
		}
		return _rightChildIndex;
	}
	
	public int getParentIndex(int childIndex, int endIndex)
	{
		if(childIndex < 0 || childIndex>endIndex)
		{
			return -1;
		}
		return (childIndex-1)/2;
	}
	
	public void Swap(int[] inputArray, int index1, int index2){
		int _tmp = inputArray[index1];
		inputArray[index1] = inputArray[index2];
		inputArray[index2] = _tmp;
	}
	
	public void Heapify(int[] inputArray, int index, int endIndex){
		int _leftChildIndex = getLeftChildIndex(index, endIndex);
		int _rightChildIndex = getRightChildIndex(index, endIndex);
		
		if(_leftChildIndex !=-1 && inputArray[_leftChildIndex] > inputArray[index])
		{
			Swap(inputArray, _leftChildIndex, index);
			Heapify(inputArray, _leftChildIndex, endIndex);
		}
		if(_rightChildIndex !=-1 && inputArray[_rightChildIndex] > inputArray[index])
		{
			Swap(inputArray, _rightChildIndex, index);
			Heapify(inputArray, _rightChildIndex, endIndex);
		}
	}
	
	public void BuildHeap(int[] inputArray)
	{
		int endIndex = inputArray.Count()-1;
		int parentIndex = getParentIndex(endIndex,endIndex);
		
		while(parentIndex >=0){
			Heapify(inputArray,parentIndex, endIndex);
			parentIndex--;
		}
	}
	
	public void HeapSort(int[] inputArray)
	{
		inputArray.Dump();
		BuildHeap(inputArray);
		inputArray.Dump();
		
		int endIndex = inputArray.Count()-1;
		while(endIndex>0)
		{
			Swap(inputArray,0,endIndex);
			endIndex--;
			Heapify(inputArray, 0, endIndex);
		}
	}
}

// Define other methods and classes here