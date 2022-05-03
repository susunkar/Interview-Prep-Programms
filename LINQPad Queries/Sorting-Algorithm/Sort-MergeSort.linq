<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	int[] myArr = new int[] {4,2,8,3,6,5,7,1};
	MergeSort(myArr,0,myArr.Length-1);
	myArr.Dump();
}
public void MergeSort(int[] numbers, int left, int right)
{
	int mid;
	if (right > left)
	{
		mid = (right + left) / 2;
		MergeSort(numbers, left, mid);
		MergeSort(numbers, (mid + 1), right);
		MainMerge(numbers, left, mid +1, right);
	}
}
public void MainMerge(int[] numbers, int leftLow, int mid, int rightLow)    
{    
    int[] auxArry = new int[numbers.Length];    
    int i;   
    int auxArryMid = (mid - 1);    
    int auxArryIndex = leftLow;
	int num = (rightLow - leftLow + 1);
	
	while ((leftLow <= auxArryMid) && (mid <= rightLow))    
    {    
        if (numbers[leftLow] <= numbers[mid])    
            auxArry[auxArryIndex++] = numbers[leftLow++];    
        else    
            auxArry[auxArryIndex++] = numbers[mid++];    
    }    
    while (leftLow <= auxArryMid)    
        auxArry[auxArryIndex++] = numbers[leftLow++];    
    while (mid <= rightLow)
		auxArry[auxArryIndex++] = numbers[mid++];
		
	for (i = 0; i < num; i++)
	{
		numbers[rightLow] = auxArry[rightLow];
		rightLow--;
	} 	
}

/*
	MergeSort is Fast 
	Divide, conquer and merge algorithm
	
	MergeSort(input)
	1. if(input.count == 1) 
	2.		return input
	3. else
	4.		sortedLeft = MergeSort(left(input))
	5.		sortedRight = MergeSort(right(input))
	6.		return mergeArray(sortedLeft,sortedRight)
	
	mergeArray(left, right)
	1. mergeArray = Empty
	2. While (notEmpty(left) and notEmpty(right))
	3.	if(isEmpty(left)) mergeArray.add(right[i])
	4.	else if(isEmpty(right)) mergeArray.add(left[i])
	5.	else if(left[i] < right[i]) mergeArray.add(left[i])
	6.	else  mergeArray.add(right[i])
*/

// Define other methods and classes here