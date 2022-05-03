<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	//Validate Subsequence set of array
	var r = IsValidSubsequence(new List<int> {5,1,22,25,6,-1,8,10 }, new List<int>  {1,6,-1,8});
	r.Dump();

}
public bool IsValidSubsequence(List<int> array, List<int> sequence)
{
	int rcounter = 0;
	for (var i = 0; i < array.Count; i++)
	{
		if (array[i] == sequence[rcounter]){
			//Console.WriteLine($"{array[i]}, {sequence[rcounter]} count{rcounter}");
			if (rcounter == sequence.Count-1)
			{
				return true;
			}
			rcounter +=1;
			continue;
		}
	}
	return false;
}


// Define other methods, classes and namespaces here
