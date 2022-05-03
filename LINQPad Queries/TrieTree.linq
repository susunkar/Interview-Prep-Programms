<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

public class Solution
{
    public static void Main()
    {
        string search = "Bat";

        TrieTree trietree = new TrieTree();

        trietree.CreateTrieTree ("Cat");
        trietree.CreateTrieTree ("Bat");
        trietree.CreateTrieTree ("Rat");
        trietree.CreateTrieTree ("Bar");
        
        bool result = trietree.Search (search);

        Console.WriteLine ("*** Search of {0} {1} ***", search, result);
    }


    public class TrieNode
    {
        public Dictionary<char, TrieNode> child = new Dictionary<char, TrieNode>();
        public string word= "";
    }


    public class TrieTree
    {
        public TrieNode root = new TrieNode();
        public char endSymbol = '*';

        public void CreateTrieTree (string input)
        {
            string[] words = input.Split (',');
            
            for (int i = 0; i<words.Length; i++)
            {
                CreateTrie(words [i], root);
            }
        }

        public void CreateTrie (string word,TrieNode tempRoot)
        {
            TrieNode temp = tempRoot;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word [i];
                if (!temp.child.ContainsKey (letter))
                {
                    TrieNode t =  new TrieNode();
                    temp.child.Add (letter, t);
                }
                temp = temp.child[letter];
            }
            temp.child[endSymbol] = null;
            temp.word = word;
        }

        public bool Search (string search)
        {
            TrieNode temp = root;
            for(int i = 0; i<search.Length; i++){
                if(!temp.child.ContainsKey(search[i])){
                    return false;
                }
                temp = temp.child[search[i]];
                if(temp.child.ContainsKey(endSymbol)){
                    return true;
                }
            }
            return false;
        }
    }
}
