<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	Random randNum = new Random();

	int[] inputarray = Enumerable
		.Repeat(0, 150000)
		.Select(i => randNum.Next(1, 15000))
		.ToArray();
		
	InserionSort(inputarray);

	inputarray.Dump();

}

/*
Insertion sort start with a sorted sub-List of size 1
Thissort first assumes a sorted list of size 1 and insert additional 
elements in the right position, 

Time complexityO(N^2)
space complexity O(1) extra space

It's is stable sort as entities bubble to the correct position in the sublist that is sorted the list the original order of entities are maintained for equal elements

This is similar to bubble sort, it is adaptive in that nearly sorted lists complete very quickly

It has very low overhead and is traditionally the sort of choice when used with faster algorithmswhich follow the divide and conquer aproach

Insertion sort vs bubble sort
1. bubble sort requires an additional pass over all elements to ensure that the list is fully sorted
2. bubble sort has to do n comparisons at every step. insertion sort can stop comparison elelments when the right poistion the sorted list is found.
3. bubble sor performs poorly with modern hardware because of the number of writes and swaps that it performs, result in caxhe misses so had greater overhead than insertion sort
   
*/
public void InserionSort (int[] arrya)
{
	for (int i = 0; i < arrya.Length-1; i++)
	{
		for(int j = i +1 ; j>0 ; j--){  
			if(arrya[j]<arrya[j-1]){ 		
				var temp = arrya[j-1];
				arrya[j-1]=arrya[j];
				arrya[j] = temp;
				
			}
			else{
				break;
			}
		}
	}
}
// Define other methods and classes here