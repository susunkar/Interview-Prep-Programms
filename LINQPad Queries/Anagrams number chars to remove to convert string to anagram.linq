<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	/*
		Anagrams: same letters, same count, different orders
		ex: hello vs billion (anagram is llo, first string we need to remove 2char 'h','e' and seco
		nd	string we need to remove 4 char	'b','i','i,'n' to make anagram)
		
		ex: glue vs legs (gle)
		ex: candy vs day (day)
		
	*/
	
	numberNeeded("hello","billion").Dump();
}
public static int numberNeeded (string first, string second){
	int[] charCount1 = getCharCounts(first);
	int[] charCount2 = getCharCounts(second);
	return getDelta(charCount1, charCount2);
}

static int getDelta(int[] charCount1, int[] charCount2)
{
	if(charCount1.Length != charCount2.Length)
		return -1;
	
	int delta = 0;
	for(int i =0 ; i<charCount1.Length ;i++){
		int difference = Math.Abs(charCount1[i] - charCount2[i]);
		delta += difference;
	}
	return delta;
}

static int[] getCharCounts(string s)
{
	int maxLenth = 26;
	int[] charCounts = new int[maxLenth];
	
	foreach(var i in s.ToArray()){
		int offset = (int) 'a';
		int code = i - offset;//char co code 
		charCounts[code]++; // char count increment
	}
	charCounts.Dump("***");
	return charCounts;
	
}

// Define other methods and classes here
