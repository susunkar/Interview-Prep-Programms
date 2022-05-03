<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
</Query>

void Main()
{
    /// <summary>
    /// BoggleBoard
    /// </summary>

    char [,] board = {
            {'t', 'h', 'i', 's', 'i', 's', 'a'},
            {'s', 'i', 'm', 'p', 'l', 'e', 'x'},
            {'b', 'x', 'x', 'x', 'x', 'e', 'b'},
            {'x', 'o', 'g', 'g', 'l', 'x', 'o'},
            {'x', 'x', 'x', 'D', 'T', 'r', 'a'},
            {'R', 'E', 'P', 'E', 'A', 'd', 'x'},
            {'x', 'x', 'x', 'x', 'x', 'x', 'x'},
            {'N', 'O', 'T', 'R', 'E', '-', 'P'},
            {'x', 'x', 'D', 'E', 'T', 'A', 'E'},
        };
    string[] words = {"this", "is", "not", "a", "simple", "boggle", "board", "test", "REPEATED", "NOTRE-PEATED"};
    string[] expected ={"this", "is", "a", "simple", "boggle", "board", "NOTRE-PEATED"};
    
    List<string> actual = BoggleBoard (board, words);
    
    Xunit.Assert.True (actual.Count == expected.Length,"PASS".Dump());
    
    foreach (string word in actual)
    {
        Xunit.Assert.True (Contains (expected, word),"PASS".Dump());
    }

}
public static bool Contains (string[] wordArray, string targetWord)
{
    foreach (string word in wordArray)
    {
        if (targetWord.Equals (word))
        {
            return true;
        }
    }
    return false;
}

public static List<string> BoggleBoard (char [,] board, string[] words)
{

    Trie trie = new Trie();
    foreach (string word in words)
    {
        trie.Add (word);
    }
    HashSet<string> finalWords = new HashSet<string> ();
    bool [,] visited = new bool [board.GetLength (0), board.GetLength (1)];
    
    for (int i = 0; i < board.GetLength (0); i++)
    {
        for (int j = 0; j < board.GetLength (1); j++)
        {
            explore (i, j, board, trie.root, visited, finalWords);
        }
    }
    List<string> finalWordsArray = new List<string>();
    foreach (string key in finalWords)
    {
        finalWordsArray.Add (key);
    }
    return finalWordsArray;

}

public static void explore (int i, int j, char [,] board, TrieNode trieNode, bool [,] visited , HashSet<string> finalWords)
{
    if (visited [i, j])
    {
        return;
    }
    char letter = board [i, j];
    if (!trieNode.childern.ContainsKey (letter))
    {
        return;
    }
    visited [i, j] = true;
    trieNode = trieNode.childern [letter];
    if (trieNode.childern.ContainsKey ('*'))
    {
        finalWords.Add (trieNode.word);
    }
    List<int[]> neighbors = getNeighbors (i, j, board);
    foreach (int[] neighbor in neighbors)
    {
        explore (neighbor [0], neighbor [1], board, trieNode, visited, finalWords);
    }
    visited [i, j] = false;
}

public static List<int[]> getNeighbors (int i, int j, char [,] board)
{
    List<int[]> neighbour = new List<int[]> ();

    if (i > 0 && j > 0)
    {
        neighbour.Add (new int[] { i - 1, j - 1 });
    }
    if (i > 0 && j < board.GetLength (1) - 1)
    {
        neighbour.Add (new int[] { i - 1, j + 1 });
    }
    if (i < board.GetLength (0) - 1 && j < board.GetLength (1) - 1)
    {
        neighbour.Add (new int[] { i + 1, j + 1 });
    }
    if (i < board.GetLength (0) - 1 && j > 0)
    {
        neighbour.Add (new int[] { i + 1, j - 1 });
    }
    if (i > 0)
    {
        neighbour.Add (new int[] { i - 1, j });
    }
    if (i < board.GetLength (0) - 1)
    {
        neighbour.Add (new int[] { i + 1, j });
    }
    if (j > 0)
    {
        neighbour.Add (new int[] { i, j - 1 });
    }
    if (j < board.GetLength (1) - 1)
    {
        neighbour.Add (new int[] { i, j + 1 });
    }
    return neighbour;
}

public class TrieNode
{
    public Dictionary<char, TrieNode> childern = new Dictionary<char, TrieNode>();
    public string word = "";
}

public class Trie
{
    public TrieNode root;
    public char endSymbol;

    public Trie()
    {
        this.root = new TrieNode();
        this.endSymbol = '*';
    }

    public void Add (string str)
    {
        TrieNode node = this.root;

        for (int i = 0; i < str.Length; i++)
        {
            char letter = str [i];
            if (!node.childern.ContainsKey (letter))
            {
                TrieNode newNode = new TrieNode();
                node.childern.Add (letter, newNode);
            }
            node = node.childern [letter];
        }
        node.childern [this.endSymbol] = null;
        node.word = str;
    }
}
// Define other methods, classes and namespaces here
