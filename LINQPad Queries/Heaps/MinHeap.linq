<Query Kind="Program" />

void Main()
{
	MaxHeap Maxheap = new MaxHeap();
	
	Maxheap.Peek().Dump();
	
	
	Maxheap.Insert(10);
	Maxheap.Insert(15);
	Maxheap.Insert(20);

	Maxheap.Insert(17);
	Maxheap.Insert(25);
	Maxheap.Insert(9);
	Maxheap.items.Dump();
	
	Maxheap.Delete();
	Maxheap.items.Dump();
}
public class MaxHeap{
	private static int Capacity =10;
	private int size  = 0 ;
	
	public int[] items = new int[Capacity];

	private int GetLeftChildIndex(int parentIndex) { return (parentIndex *2) +1 ;}
	private int GetRightChildIndex(int parentIndex) { return (parentIndex * 2) + 2; }
	private int GetParentIndex(int childIndex) { return (childIndex - 1)/2;}

	private bool HasLeftChild(int parentIndex) { return GetLeftChildIndex(parentIndex) < size;}
	private bool HasRightChild(int parentIndex) { return GetRightChildIndex(parentIndex) < size; }
	private bool HasParent(int childIndex) {return GetParentIndex(childIndex) >=0; }

	private int GetLeftChildValue(int index) { return items[GetLeftChildIndex(index)];}
	private int GetRightChildValue(int index) { return items[GetRightChildIndex(index)];}
	private int GetParentValue(int index) { return items[GetParentIndex(index)];}
	
	
	private void Swap(int indexOne, int indexTwo){
		int temp = items[indexOne];
		items[indexOne] = items[indexTwo];
		items[indexTwo] = temp;
	}
	
	public int Peek(){
		if(size == 0) {
			Console.WriteLine("No Element in Items array");
			return -1;
		}
		return items[0]; 
	}
	
	// In heap delete performs only at root level then 
	// take last element and update in root element 
	// do heapifyDown to rearrange value
	public  int Delete(){
		if(size == 0) {
			throw new Exception();
		}
		//taking backup of root element
		int temp = items[0];
		
		//Updating root element with last element in array
		items[0] = items[size-1];
		items.Dump();
		//reusing the array for deleting elements, so that ones all element we do delete the array has sorted array
		items[size-1] = 0;
		size--;
		
		HeapifyDown();
		return temp;
	}
	// In heap insert performs only at last in array 
	// do heapifyUp to rearrange value
	public  void Insert(int item)
	{
		if (size >= Capacity)
		{
			throw new Exception();
		}
		//taking backup of root element
		items[size] = item;
		size++;
		HeapifyUp();
	}

	private void HeapifyUp()
	{
		int index = size - 1;
		while(HasParent(index) && GetParentValue(GetParentIndex(index)) > items[index]){
			Swap(index,GetParentIndex(index));
			index = GetParentIndex(index);
		}
	}
	void HeapifyDown()
	{
		int index = 0;
		//check index HasParent and Parent is Greater then LeftChild and RightChild
		while(HasLeftChild(index)){
			int smallerChildIndex = GetLeftChildIndex(index);
			
			if(HasRightChild(index) && GetRightChildValue(index) < GetLeftChildValue(index)){
				smallerChildIndex = GetRightChildIndex(index);
			}
			if(items[index] < items[smallerChildIndex]) break;
			else {
				Swap(index, smallerChildIndex);
			}
			index= smallerChildIndex;
		}
	}
}
// Define other methods and classes here
