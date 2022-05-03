<Query Kind="Program" />

void Main()
{
	int[] arr = {5,8,3,9,6,2,10,7,-1,4};
	
	int min= arr[0];
	int max = arr[0];
	int minsec= arr[0];
	int maxSec = arr[0];
	
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] < min)
		{
			minsec = min;
			min = arr[i];
		}
		else
		{
			if (arr[i] > max) { 
				maxSec = max;
				max = arr[i];
			}
		}
	}
	min.Dump("min");
	max.Dump("max");
	minsec.Dump("min Sec");
	maxSec.Dump("max Sec");
}

// Define other methods and classes here
