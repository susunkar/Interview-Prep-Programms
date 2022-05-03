<Query Kind="Program">
  <Namespace>static UserQuery</Namespace>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	MinHeap<int> minHeap = new MinHeap<int>(typeof(Int32));
	minHeap.insert(9);
	minHeap.insert(4);
	minHeap.insert(17);
	minHeap.printHeapArray();
	minHeap.insert(6);
	minHeap.printHeapArray();

	minHeap.insert(100);
	minHeap.insert(20);
	minHeap.printHeapArray();
	minHeap.insert(2);
	minHeap.insert(1);
	minHeap.insert(5);
	minHeap.insert(3);
	minHeap.printHeapArray();

	minHeap.removeHighestPriority();
	minHeap.printHeapArray();
	minHeap.removeHighestPriority();
	minHeap.printHeapArray();
	
}

public abstract class Heap<T> where T : IComparable
{
	private static int MAX_SIZE = 40;
	private T[] array;
	private int count = 0;

	public Heap(Type clazz)
	{
		clazz = typeof(T);
		array = (T[])Array.CreateInstance(clazz, MAX_SIZE);
	}

	public int getLeftChildIndex(int index)
	{
		int leftChildIndex = 2 * index + 1;

		if (leftChildIndex >= count)
		{
			return -1;
		}
		return leftChildIndex;
	}
	
	public int getRightChildIndex(int index)
	{
		int rightChildIndex = 2 * index +2;
		
		if(rightChildIndex >= count)
		{
			return -1;
		}
		return rightChildIndex;
	}
	
	public int getParentIndex(int Index)
	{
		if(Index <0 || Index >count)
			return -1;
			
		return (Index -1)/2;
	}
		
	public int getCount(){
		return count;
	}
	
	public bool isFul()
	{
		return count == array.Length;
	}
	
	public T getElementAtIndex(int index){
		return array[index];
	}
	
	protected void swap(int index1, int index2)
	{
		T tempValue = array[index1];
		array[index1] = array[index2];
		array[index2] = tempValue;
	}
	
	protected internal abstract void siftDown(int index);

	protected internal abstract void siftUp(int index);
	
	public virtual void insert(T value)
	{
		if (count >= array.Length)
		{
			throw new Exception();
		}

		array[count] = value;
		siftUp(count);

		count++;
	}
	
	public virtual T removeHighestPriority()
	{
		T min = HighestPriority;

		array[0] = array[count - 1];
		count--;
		siftDown(0);

		return min;
	}

	public virtual T HighestPriority
	{
		get
		{
			if (count == 0)
			{
				throw new Exception();
			}

			return array[0];
		}
	}
	public virtual void printHeapArray()
	{
		for (int i = 0; i < count; i++)
		{
			Console.Write(array[i] + ", ");
		}
		Console.WriteLine();

		try
		{
			Console.WriteLine("Highest priority: " + HighestPriority);
		}
		catch (Exception)
		{

		}
	}
}

public class MinHeap<T> : Heap<T> where T : IComparable
{
	public MinHeap(Type clazz):base(clazz)
	{
		clazz = typeof(T);
	}

	public MinHeap(Type clazz, int size):base(clazz)
	{
		clazz = typeof(T);
		
	}

	protected internal override void siftDown(int index)
	{
		int leftIndex = getLeftChildIndex(index);
		int rightIndex = getRightChildIndex(index);

		// Find the minimum of the left and right child elements.
		int smallerIndex = -1;
		if (leftIndex != -1 && rightIndex != -1)
		{
			smallerIndex = getElementAtIndex(leftIndex).CompareTo(getElementAtIndex(rightIndex)) < 0 ? leftIndex : rightIndex;
		}
		else if (leftIndex != -1)
		{
			smallerIndex = leftIndex;
		}
		else if (rightIndex != -1)
		{
			smallerIndex = rightIndex;
		}

		// If the left and right child do not exist stop sifting down.
		if (smallerIndex == -1)
		{
			return;
		}

		// Compare the smaller child with the current index to see if a swap
		// and further sift down is needed.
		if (getElementAtIndex(smallerIndex).CompareTo(getElementAtIndex(index)) < 0)
		{
			swap(smallerIndex, index);
			siftDown(smallerIndex);
		}
	}

	protected internal override void siftUp(int index)
	{
		int parentIndex = getParentIndex(index);

		if (parentIndex != -1 && getElementAtIndex(index).CompareTo(getElementAtIndex(parentIndex)) < 0)
		{
			swap(parentIndex, index);

			siftUp(parentIndex);
		}
	}
	
}

