<Query Kind="Program" />

/*
Write a function allConstruct(target, wordBank) that accepts a target string and an array of  strings.

The function should return a 2D array containing all of the ways that the target can be constucted by concatenation elements of the wordBank array. 
Each element of the 2D arry should represent one combination that constructs the target.

You may reuse elements of wordBank as many times as needed.
*/
void Main()
{
	allConstuct ("purple", new List<string> () {"purp","p", "ur", "le", "purpl"}).Dump();
	/*
		[
			["purp","le"],
			["p","ur","p","le"]
		]
	*/
	allConstuct ("abcdef", new List<string> () { "ab", "abc", "cd", "def", "abcd", "ef", "c" }).Dump();
	/*
		[
			["ab","cd","ef"],
			["ab","c","def"],
			["abc","def"],
			["abcd","ef"],
		]
	*/
	allConstuct ("skateboards", new List<string> () { "bo", "rd", "ate", "t", "ska", "sk", "board" }).Dump();
	/*
		[]
	*/
	allConstuct ("aaaaaaaaaaaaaaaaaaaaaz", new List<string> () { "a", "aa", "aaa", "aaaa", "aaaaa"}).Dump();
	/*
		[]
	*/
}

List<List<string>> allConstuct (string target, List<string> wordBank)
{
	if (target == "") return new List<List<string>> () { new List<string>() { }};
	
	List<List<string>> result= new List<List<string>>();
	foreach (var word in wordBank)
	{
		if(target.IndexOf(word)==0){
			var suffix = target.Remove(0,word.Length);
			var suffixresult = allConstuct (suffix, wordBank);
		
			suffixresult.ForEach (s =>
			{
				s.Add( word );
			});
			result.AddRange(suffixresult);
		}
	}
	return result;
}


