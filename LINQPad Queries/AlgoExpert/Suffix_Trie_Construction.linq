<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	SuffixTrie sufxTrie = new SuffixTrie("Car");
	sufxTrie.PopulateSuffixTrieFrom("Cat");
	sufxTrie.PopulateSuffixTrieFrom("Bar");
	sufxTrie.PopulateSuffixTrieFrom("Try");
	sufxTrie.PopulateSuffixTrieFrom("Card");
	
	sufxTrie.root.Dump();
	sufxTrie.Contains("rd").Dump();
}

public class TrieNode
{
	public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
}

public class SuffixTrie
{
	public TrieNode root = new TrieNode();
	public char endSymbol = '*';

	public SuffixTrie(string str)
	{
		PopulateSuffixTrieFrom(str);
	}

	public void PopulateSuffixTrieFrom(string str)
	{
		for(int i=0; i<str.Length;i++){
			PupulateSuffixTrieAt(i,str);
		}
		
	}

	void PupulateSuffixTrieAt(int i, string str)
	{
		var troot = this.root;
		
		for(int j= i; j<str.Length; j++){
			var letter = str[j];
			
			if (!troot.Children.ContainsKey(letter)){
				troot.Children.Add(letter,new TrieNode());
			}
			troot = troot.Children[letter];
		}
		troot.Children[endSymbol]= null;
	}

	public bool Contains(string str)
	{
		var troot = this.root;

		for (int j = 0; j < str.Length; j++)
		{
			var letter = str[j];
			if (!troot.Children.ContainsKey(letter))
			{
				return false;
			}
			troot = troot.Children[letter];
		}
		
		return troot.Children.ContainsKey(endSymbol);
	}
}


// Define other methods, classes and namespaces here
