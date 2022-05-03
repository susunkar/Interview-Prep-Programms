<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

//KMP-Pie table for pattern string O(n+m)
void Main()
{
	/*
	Examples of lps[] construction:
	For the pattern “AAAA”, 
	lps[] is [0, 1, 2, 3]

	For the pattern “ABCDE”, 
	lps[] is [0, 0, 0, 0, 0]

	For the pattern “AABAACAABAA”, 
	lps[] is [0, 1, 0, 1, 2, 0, 1, 2, 3, 4, 5]

	For the pattern “AAACAAAAAC”, 
	lps[] is [0, 1, 2, 0, 1, 2, 3, 3, 3, 4] 

	For the pattern “AAABAAA”, 
	lps[] is [0, 1, 2, 0, 1, 2, 3]
	*/
	string inputString = "my name is suresh, I'm suresh kumar";
	//string pattern = "suresh";
	string pattern = "ABAABAAC";
	KMPStringMatch(inputString,pattern);
	
}

public int[] KMP_PIETable(string pattern){

	int m = pattern.Length;
	int[] loc = new int[m];

	int i = 1;
	int j = 0;

	while (i < m )
	{
		if (pattern.ElementAt(i) == pattern.ElementAt(j))
		{
			j++;
			loc[i] = j;
			i++;
		}
		else
		{
			if(j != 0){
				j = loc[j-1];
			}
			else{
				loc[i] = j;
				i++;
			}
		}

	}
	loc.Dump();
	
	return loc;
}

public void KMPStringMatch(string inputMsg, string pattern){
	
	var loc = KMP_PIETable(pattern);
	int j =0;
	for (int i=0 ; i<inputMsg.Length;i++){
		if(inputMsg.ElementAt(i) == pattern.ElementAt(j+1)){
			j++;
		}
		else{
			j= loc[j];
		}
		if (j == loc.Length-1)
		{
			Console.WriteLine($"pattern match at {i-j}");
			j=0;
		}
	}

}

// Define other methods, classes and namespaces here