<Query Kind="Program" />

void Main()
{
	string target1 = "abcdef";
	string[] words1 = { "ab", "abc", "cd", "def", "abcd" };
	string target2 = "skateboard";
	string[] words2 = { "bo", "rd", "ate", "t", "ska","sk","boar" };

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
	canConstruct(target,words,memo).Dump();
	bool canConstruct (string target, string[] words,Hashtable memo){
		if(memo.Contains(target)) return  (bool) memo[target];
		
		if(string.IsNullOrEmpty(target) ) return true;
		
		for(int i=0 ; i<words.Count();i++){
			if(target.IndexOf(words[i])==0){
				var suftarget = target.Remove(0, words[i].Length);
				if (canConstruct(suftarget, words,memo))
				{
					memo.Add(target, true);
					return true;
				}
			}
		}
		memo.Add(target, false);
		return false;
	}
}

// You can define other methods, fields, classes and namespaces here