<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	/*
	Largest Range : Arrays
	The first number in the output array should be the first number in the range, while the second number should be the last number in the range.
	{2,3,4,5,6} out put [2,6]

	array = [1,11,3,0,15,5,2,4,10,7,12,6] out put [0,7]
	O(n) time | O(n) space
	*/

	int[] array = new int[] { 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 12, 6};
	LargestRange(array).Dump(); 
}
public static int[] LargestRange(int[] array){
	int[] bestRange = new int[2];
	int longestLength = 0;
	
	HashSet<int> nums = new HashSet<int>();
	
	foreach (int n in array)
	{
		nums.Add(n);		
	}
	
	foreach (int n in array)
	{
		if(nums.Contains(n) == false){
			continue;
		}
		nums.Remove(n);
		
		int currentLenght = 1;
		int left = n -1;
		int right = n +1;
		
		while(nums.Contains(left)){
			currentLenght++;
			left--;
			nums.Remove(n);
		}
		while (nums.Contains(right))
		{
			currentLenght++;
			right++;
			nums.Remove(n);
		}

		if (currentLenght > longestLength)
		{
			longestLength = currentLenght;
			bestRange = new int[]{left+1, right-1};
		}
	}
	return bestRange;
}


// Define other methods, classes and namespaces here
