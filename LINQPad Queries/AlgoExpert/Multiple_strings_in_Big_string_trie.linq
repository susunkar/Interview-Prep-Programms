<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	/*
	Multi String a big string
	Note: not use built in string function
	
	Big string: this is a big string
	small string: [this, yo, is , a, bigger, string, kappa]
	
	out: [true,false, true, true, false, true, false] 
	
	this kind of problem can use trie (suffix trie)
	time: O(bn + bs)
	space: O(ns)
	*/

	string bigstring = "this is a big string";
	string[] smallstrings = new string[] {"this","yo", "is", "a", "bigger", "string", "kappa"};
	MultstringSearch(bigstring, smallstrings).Dump();
}
public static List<bool> MultstringSearch(string bigstring, string [] smallstrings){
	Trie trie = new Trie();
	foreach(string smallstring in smallstrings){
		trie.insert(smallstring);
	}
	
	HashSet<string> containedstrings = new HashSet<string>();
	for(int i=0; i<bigstring.Length;i++){
		findSmallStringsIn(bigstring,i,trie,containedstrings);
	}
	
	List<bool> solution = new List<bool>();
	foreach(string str in smallstrings){
		solution.Add(containedstrings.Contains(str));
	}
	return solution;
}

static void findSmallStringsIn(string str, int startIdx, Trie trie, HashSet<string> containedstrings)
{
	TrieNode currentNode = trie.root;
	for(int i = startIdx; i<str.Length; i++){
		char currentChar = str[i];
		if(!currentNode.children.ContainsKey(currentChar)){
			break;
		}
		currentNode = currentNode.children[currentChar];
		if(currentNode.children.ContainsKey(trie.endSymbol)){
			containedstrings.Add(currentNode.word);
		}
	}
}

public class TrieNode {
	public Dictionary<char,TrieNode> children = new Dictionary<char, UserQuery.TrieNode>();
	public string word;
}

public class Trie{
	public TrieNode root = new TrieNode();
	public char endSymbol = '*';

	public void insert(string str)
	{
		TrieNode node = root;
        
		for (int i = 0; i < str.Length; i++){
			char letter = str[i];
			if(!node.children.ContainsKey(letter)){
				TrieNode newNode = new TrieNode();
				node.children.Add(letter, newNode);
			}
			node = node.children[letter];
		}
		
		node.children[endSymbol] = null;
		node.word = str;
	}
	
}
// Define other methods, classes and namespaces here
