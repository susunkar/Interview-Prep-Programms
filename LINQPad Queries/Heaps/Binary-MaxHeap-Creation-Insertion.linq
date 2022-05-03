<Query Kind="Program" />

void Main()
{
	int[] arry = { 10, 20, 30, 25, 5, 40, 35 };
	// 40,25,35,10,5,20,30
	
	int i = 0;
	while (i < arry.Length)
	{
		//One by one inserting/creating MAXHeap from normal array 
		CreateMaxHeapOrInsertElementInMaxHeap(arry, i);
		i++;
	}
	Display(arry);


	int[] arry1 = { 40, 35, 30, 15, 10, 25, 5 };
	// 40,25,35,10,5,20,30
	i = 0;
	while (i<arry1.Length)
	{
		//Deleting one by one element from MaxHeap it give accessing order element
		Delete(arry1,((arry1.Length-1)-i));
		//Display(arry);
		i++;
	}
	Display(arry1);
}
public static void CreateMaxHeapOrInsertElementInMaxHeap(int[] arr, int lastIndex){
	//Take Least node or First Insert new element at last index
	int temp = arr[lastIndex];
	
	//Get the index of last ement
	int loopend = lastIndex;
	//Find the parent index 
	int parent = (lastIndex - 1) / 2;
	
	//Check condtion accoding to MAX or Min, in below Max Logic
	//1. precondition of MAX Heap is the root is maximum value of it child
	//2. Check new element/child value to parent value is less, if child is greated the parent
	while (loopend > 0 && temp > arr[parent])
	{
		//update child index value to new parent 
		arr[loopend] = arr[parent];
		//reset current position  
		loopend = parent;
		//get new position parent index
		parent = (parent - 1) / 2;
	}
	//after end the loop, we get right index of new element, update it
	arr[loopend] = temp;

}
void Display(int[] arry)
{
	for (int i = 0; i < arry.Length; i++)
	{
		Console.Write("{0} ", arry[i]);
	}
	Console.WriteLine();
}

//Note Deleting all element give sorted arry
//Heap delete : root element only delete in heap
void Delete(int[] arry,int lastpostion){

	//Take root element for deletion
	int x = arry[0];
	
	//root place will take by last not in the heap
	arry[0] = arry[lastpostion];
	
	//reusing the deleted position to get sort arry
	arry[lastpostion] = x;
	
	//compair root child nodes
	int rootIndex = 0;
	int leftChildNode = (2 * rootIndex) + 1;
	int rightChildNode = (2 * rootIndex) + 2;
	
	while (rootIndex < arry.Length && rightChildNode <lastpostion)
	{
		//Greater Node in childs
		if (arry[leftChildNode] > arry[rightChildNode])
		{
			//Now swap the left to right
			Swap(arry,leftChildNode, rightChildNode);

			//Now compar root to greate value child
			if (arry[leftChildNode] > arry[rootIndex])
			{
				//Now swap the root to it leftchild
				Swap(arry, leftChildNode, rootIndex);
			}

		}
		//Now compar root to greate value child
		if (arry[rightChildNode] >  arry[rootIndex])
		{
			Swap(arry, rightChildNode, rootIndex);
		}

		rootIndex++;
		leftChildNode = (2 * rootIndex) + 1;
		rightChildNode = (2 * rootIndex) + 2;
	}
}

private void Swap(int[] arr, int leftChildIndex, int rightChildIndex)
{
	int temp = arr[rightChildIndex];
	arr[rightChildIndex] = arr[leftChildIndex];
	arr[leftChildIndex] = temp;
}
// Define other methods and classes here