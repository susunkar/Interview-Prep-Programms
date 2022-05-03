<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	/*
	Selection Sort
	• O(n^2). Example: A slow sorting algorithm, like selection sort
		(coming up in chapter 2).
	*/
	int[] myarr = new int[]{7, 3, 6, 4, 2, 1 };
	SelectionSort(myarr);
	myarr.Dump();
}

/*
It's naevi sort method, and no where use it.
For each element the entire list is checked to find the smallest elelemt

so in the worst case 'N' elements are checked for every selected element
it is not a stable sort entities which are equal might be re-arranged
it makes O(N^2) comparisons
it is not adative, this is no wat to knowed entire list is sorted and break out from loop
*/
public void SelectionSort (int[] array){
	
	for (int i = 0 ; i < array.Count(); i++)
	{
		for(int j = i+1 ; j<array.Count();j++){
			if(array[i] > array[j]){
				//swap
				var temp = array[j];
				array[j] = array[i];
				array[i] = temp;
				array.Dump();
			}
		}
	}
}

public void SelectionSortv2(int[] a){
	
	for (int i =0 ; i<a.Length; i++){
		for (int j= i+ 1; j<a.Length; j++){
			if(a[i]>a[j])
				swapArrayElements(a, i, j);
		}
	}
}
public void swapArrayElements(int[] a, int left, int right ){
	
	int temp = a[right];
	a[right] = a[left];
	a[left] = temp;
}


public void SelectionSortV3(int[] a){
	
	for(int i =0 ; i < a.Length; i++){
		int smallestValueIndex = getSmallestIndex(a, i);
		int temp = a[smallestValueIndex];
		a[smallestValueIndex] = a[i];
		a[i] = temp;
	}
}

public int getSmallestIndex (int[] a, int currentIndex){
	
	int currentIndexValue = a[currentIndex];
	int smallestValueIndex = currentIndex;
	
	while (currentIndex < a.Length){
		if(currentIndexValue >= a[currentIndex]){
			currentIndexValue = a[currentIndex];
			smallestValueIndex = currentIndex;
		}
		currentIndex ++;
	}
	return smallestValueIndex--;
}