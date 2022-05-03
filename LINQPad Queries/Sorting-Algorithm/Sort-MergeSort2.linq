<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	int[] myArr = new int[] {9,4,10,2,8,13,3,6,5,7,1};
	int[] auxArr = new int[myArr.Count()];
	
	myArr.CopyTo(auxArr,0);
	
	merger_array(myArr,auxArr,0, myArr.Count());
	myArr.Dump();
	auxArr.Dump();
}

public void merger_array(int[] inputArray, int[] resultArray, int start, int end ){
	
	if(end - start < 2) return ;
	
	if(end - start == 2 ){
		if(resultArray[start] > resultArray[end-1]){
			Swap(resultArray,start, end-1);
			return;
		}
	}

	int mid = (start + end) / 2;

	merger_array(resultArray,inputArray, start, mid);
	merger_array(resultArray,inputArray , mid, end);

	//n merge is now ready, merge from A back into result
	
	int i = start;
	int j = mid;
	int idx = start;
	while(idx < end){
		if(j >= end || (i < mid && inputArray[i] < inputArray[j]))
		{
			resultArray[idx] = inputArray[i];
			i++;
		}
		else{
			resultArray[idx] = inputArray[j];
			j++;
		}
		idx ++;
	}
}
public static void Swap(int[] a, int l, int h)
{
	int temp = a[h];
	a[h] = a[l];
	a[l] = temp;
}
// Define other methods and classes here