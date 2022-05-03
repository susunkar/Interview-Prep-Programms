<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	/// <summary>
	/// Min Heap Construction
	/// current Node -> i
	/// childOne -> 2i+1
	/// childTwo -> 2i+2
	/// parentNode -> floor(i-1)/2
	/// </summary>
	
	List<int> array = new List<int>(){48,12,24,7,8,-5,24,391,24,56,2,6,8,41 };
	
	MinHeap mHeap = new MinHeap(array);
	mHeap.buildHeap(array).Dump();
}

public class MinHeap
{
	public List<int> heap = new List<int>();

	public MinHeap(List<int> array)
	{
		heap = buildHeap(array);
	}

	public List<int> buildHeap(List<int> array)
	{
		int firstParentIdx = (array.Count -2 ) /2;
		for(int currentIdx = firstParentIdx; currentIdx>=0; currentIdx--){
			siftDown(currentIdx,array.Count-1, array); 
		}
		return array;
	}

	public void siftDown(int currentIdx, int endIdx, List<int> heap)
	{
		int childOneIdx = currentIdx * 2 +1;
		while(childOneIdx <=endIdx){
			int childTwoIdx = currentIdx * 2 +2 <= endIdx?currentIdx *2+2 : -1;

			int idxToSwap;
			if (childTwoIdx != -1 && heap[childTwoIdx] < heap[childOneIdx]){
				idxToSwap = childTwoIdx;
			}
			else{
				idxToSwap = childOneIdx;
			}
			if(heap[idxToSwap] < heap[currentIdx]){
				Swap(currentIdx, idxToSwap, heap);
				currentIdx = idxToSwap;
				childOneIdx = currentIdx *2 +1;
			}
			else{
				return;
			}
			
		}
	}

	public void siftUp(int currentIdx, List<int> heap)
	{
		int parentIdx = (currentIdx -1)/2;
		while(currentIdx>0&& heap[currentIdx] < heap[parentIdx]){
			Swap(currentIdx,parentIdx,heap);
			currentIdx = parentIdx;
			parentIdx = (currentIdx -1 )/2;
		}
	}

	void Swap(int currentIdx, int parentIdx, List<int> heap)
	{
		int temp = heap[currentIdx];
		heap[currentIdx] = heap[parentIdx];
		heap[parentIdx] = temp;
	}

	public int Peek()
	{
		// Write your code here.
		return heap[0];
	}

	public int Remove()
	{
		Swap(0, heap.Count-1, heap);
		int valueToRemove = heap[heap.Count -1];
		heap.RemoveAt(heap.Count - 1);
		siftDown(0,heap.Count -1 , heap);
		
		return valueToRemove;
	}

	public void Insert(int value)
	{
		heap.Add(value);
		siftUp(heap.Count-1,heap);
	}
	
}
// Define other methods, classes and namespaces here
