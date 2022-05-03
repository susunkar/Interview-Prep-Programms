<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var words = new List<string>() { "yo", "act","flop","tac", "cat","oy","olfp"};
	
	var result = groupAnagrams(words);
	result.Dump();
}
	
public static int HashString(string str){
	Dictionary <char,int> charmap = new Dictionary<char, int>();
	int sum = 1;

	charmap.Add('a', 2);
	charmap.Add('b', 3);
	charmap.Add('c', 5);
	charmap.Add('d', 7);
	charmap.Add('e', 11);
	charmap.Add('f', 13);
	charmap.Add('g', 17);
	charmap.Add('h', 19);
	charmap.Add('i', 23);
	charmap.Add('j', 29);
	charmap.Add('k', 31);
	charmap.Add('l', 37);
	charmap.Add('m', 41);
	charmap.Add('n', 43);
	charmap.Add('o', 47);
	charmap.Add('p', 53);
	charmap.Add('q', 59);
	charmap.Add('r', 61);
	charmap.Add('s', 67);
	charmap.Add('t', 71);
	charmap.Add('u', 73);
	charmap.Add('v', 79);
	charmap.Add('w', 83);
	charmap.Add('x', 89);
	charmap.Add('y', 97);
	charmap.Add('z', 101);
	charmap.Add('A', 103);
	charmap.Add('B', 107);
	charmap.Add('C', 109);
	charmap.Add('D', 113);
	charmap.Add('E', 127);
	charmap.Add('F', 131);
	charmap.Add('G', 137);
	charmap.Add('H', 139);
	charmap.Add('I', 149);
	charmap.Add('J', 151);
	charmap.Add('K', 163);
	charmap.Add('L', 167);
	charmap.Add('M', 173);
	charmap.Add('N', 179);
	charmap.Add('O', 181);
	charmap.Add('P', 191);
	charmap.Add('Q', 193);
	charmap.Add('R', 197);
	charmap.Add('S', 199);
	charmap.Add('T', 211);
	charmap.Add('U', 223);
	charmap.Add('V', 227);
	charmap.Add('W', 229);
	charmap.Add('X', 233);
	
	foreach (var e in str){
		sum *= charmap[e];
	}
	return sum;
}
public static List<List<string>> groupAnagrams(List<string> words)
{
		Dictionary<int, List<string>> anagrams = new Dictionary<int, List<string>>();
		// Write your code here.
		foreach (var l in words){
			
			int shcode = HashString(l);
			if(anagrams.ContainsKey(shcode))
			{
				anagrams[shcode].Add(l);
			}
			else{
				anagrams[shcode] = new List<string>();
				anagrams[shcode].Add(l);
			}
		}
        anagrams.Dump();
		return anagrams.Values.ToList();
}
	
