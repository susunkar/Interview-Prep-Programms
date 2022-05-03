<Query Kind="Program" />

void Main()
{
	int[] arry = { 5,10,30,20,35,40,15};
	//OutPut: 40,35,30,20,10,5,15
	int i = arry.Length-1;
	Display(arry);
	while (i >=0 )
	{
		Heapify(arry, i);
		i--;
	}
	Display(arry);
}
//In Heapify alwase start from LastIndex from array
void Heapify(int[] arry, int lastIndex){
	
	//Check last element is having any child node
	int leftChildIndex = 2*lastIndex +1;
	int rightChildIndex = 2*lastIndex +2;
	
	while(leftChildIndex < arry.Length &&  rightChildIndex < arry.Length){
		//Display(arry);
		//check the left and right child node which one is greater
		if(arry[leftChildIndex] > arry[rightChildIndex])
		{
			Swap(arry, leftChildIndex, rightChildIndex);
			//Display(arry);
			
		}
		//Check rightChildIndex value to it parent
		if (arry[rightChildIndex] > arry[lastIndex])
		{
			Swap(arry, rightChildIndex, lastIndex);
			//Display(arry);
		}

		//Check leftChildIndex value to it parent
		if (arry[leftChildIndex] > arry[lastIndex])
		{
			Swap(arry, leftChildIndex, lastIndex);
			Display(arry);
		}
		lastIndex++;
		leftChildIndex = 2 * lastIndex + 1;
		rightChildIndex = 2 * lastIndex + 2;
	}
}
void Delete(int[] arry, int lastpostion)
{

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

	while (rootIndex < arry.Length && rightChildNode < lastpostion)
	{
		//Greater Node in childs
		if (arry[leftChildNode] > arry[rightChildNode])
		{
			//Now swap the left to right
			Swap(arry, leftChildNode, rightChildNode);

			//Now compar root to greate value child
			if (arry[leftChildNode] > arry[rootIndex])
			{
				//Now swap the root to it leftchild
				Swap(arry, leftChildNode, rootIndex);
			}

		}
		//Now compar root to greate value child
		if (arry[rightChildNode] > arry[rootIndex])
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
void Display(int[] arry)
{
	for (int i = 0; i < arry.Length; i++)
	{
		Console.Write("{0} ", arry[i]);
	}
	Console.WriteLine();
}
// Define other methods and classes here
