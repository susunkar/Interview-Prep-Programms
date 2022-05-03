<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	Random randNum = new Random();
	
	int[] inputarray = Enumerable
		.Repeat(0, 7)
		.Select(i => randNum.Next(1, 55))
		.ToArray();

	inputarray.Dump();

	ShellSort(inputarray);
	inputarray.Dump();
}
/*
Shell sort uses insertion sort, the entire list is divided and those sub-lists are sorted
Getting the exact complexity of shell sort is hard because it depends on the increment values chosen
also it's not clear what the best increment value is

the coplexity of shell sort is better than insertion sort as the final iteration with increment =1 has to work with anearly sorted list

the complexity of shell sort is some whre between O(N) and O(N^2)
the algorithm is adaptive since its based on insertion sort which is adaptive
*/

public void ShellSort(int[] array){
	
	int increment = array.Length/3;
	while (increment>=1)
	{
		for(int startIndex = 0 ; startIndex<increment ;startIndex++){
			insertionSort(array,startIndex,increment);
		}
		increment = increment /3;
	}
}
public static void insertionSort (int[] listToSprt, int startIndex, int increment){
	
	for(int i = startIndex ; i< listToSprt.Length; i= i+increment){
		for(int j = Math.Min(i + increment, listToSprt.Length-1) ; j-increment>=0; j=j-increment){
			if (listToSprt[j] < listToSprt[j - increment])
			{
				var temp = listToSprt[j - increment];
				listToSprt[j - increment] = listToSprt[j];
				listToSprt[j] = temp;
			}
			else{
				break;
			}
		}
	}
}


// Define other methods and classes here