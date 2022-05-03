<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	int[] inputArray = new int[] { 1,2,3,4,7,11,13,14,3,5,6,8,9,10,15,16};
	mergeSortedArray(inputArray);
	
	//inputArray.Dump();
}
public void mergeSortedArray(int[]a )
{
	int[] aux = new int[a.Count()];
	
	int mid = (a.Length)/2-1;
	
	int leftLow = 0; int rightLow = mid+1;
	int auxIndex = 0;
	int auxLenght = a.Count();
	
	while (auxIndex < auxLenght)
	{
		if(a[leftLow]<=a[rightLow] && leftLow <= mid)
		{
			aux[auxIndex] = a[leftLow];
			leftLow ++;
			auxIndex++;
		}
		else if (a[leftLow] > a[rightLow] && rightLow<=auxLenght)
		{
			aux[auxIndex] = a[rightLow];
			rightLow++;
			auxIndex++;
		}
		else if(leftLow<mid){
			aux[auxIndex] = a[leftLow];
			leftLow ++;
			auxIndex++;
		}
		else 
		{
			aux[auxIndex] = a[rightLow];
			rightLow++;
			auxIndex++;
		}
	}
	aux.Dump();
}

// Define other methods and classes here
