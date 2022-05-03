<Query Kind="Program" />

/*
Write a function canConstruct (target, wordBank) that accepts a target string and an array of strings.

The function should return a boolean indication whether or not the 
target can constucted by concatenation element of the wordBank array.

You may resue elements of wordBank as many times as needed.

canConstuct(abcdef, [ab, abc, cd, def, abcd]) -> true;
canConstuct('', [ab, abc, cd, def, abcd]) -> true;

*/
void Main()
{
	string target1 = "abcdef";
	string[] words1 = { "ab", "abc", "cd", "def", "abcd" };
	string target2 = "skateboard";
	string[] words2 = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };

	string target3 = "purple";
	string[] words3 = { "purp", "p", "ur", "le", "purpl" };

	string target4 = "enterapotentpot";
	string[] words4 = { "a", "p", "ent", "enter", "ot","o","t" };

	
	string target = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef";
	string[] words = {
	"e",
	"ee",
	"eee",
	"eeee",
	"eeeee",
	"eeeeee",
	"eeeeeee",
	"eeeeeeed"
	};


	Hashtable memo = new Hashtable();
	countConstruct(target, words,memo).Dump();
	int countConstruct(string target, string[] words, Hashtable memo)
	{
		if(memo.Contains(target)) return (int) memo[target];
		
		if (string.IsNullOrEmpty(target)) return 1;
		
		int total=0;
		
		for (int i = 0; i < words.Count(); i++)
		{
			if (target.IndexOf(words[i]) == 0)
			{
				var suftarget = target.Remove(0, words[i].Length);
				memo.Add(suftarget,1);
				total +=countConstruct(suftarget, words,memo);
				
			}
		}
		
		return total;
	}
}

// You can define other methods, fields, classes and namespaces here