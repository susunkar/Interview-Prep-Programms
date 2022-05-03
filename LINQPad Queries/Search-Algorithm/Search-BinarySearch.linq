<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	/*
	Binary Search works only in sorted array
	• O(log n), also known as log time. Example: Binary search.
	• O(n), also known as linear time. Example: Simple search.
	• O(n * log n). Example: A fast sorting algorithm, like quicksort
		(coming up in chapter 4).
	• O(n^2). Example: A slow sorting algorithm, like selection sort
		(coming up in chapter 2).
	• O(n!). Example: A really slow algorithm, like the traveling
		salesperson (coming up next!).
	*/
	int[] a = new int[] {1,2,3,4,5,6,7};
	
	BinarySearch(a,7);
}
public void BinarySearch(int[] a , int search){
	int low = 0;
	int len = a.Length -1;
	
	while(low<=len)
	{
		int mid = (low + len)/2;
		int guse = a[mid];
		
		if (guse == search)
		{
			$"Value is found {mid} value {search}".Dump();
			return ;
		}
		if(guse>search) low = mid -1;
		else low = mid +1;
	}
	
	
}
// Define other methods and classes here
