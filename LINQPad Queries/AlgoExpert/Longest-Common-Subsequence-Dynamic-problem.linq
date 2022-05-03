<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Longest Common Subsequence Dynamic problem
    /// str1: zxvvyzw
    /// str2: xkykzpw
    /// output: xyzw
    /// 
    ///     "", x, k, y, k, z, p, w
    ///  ""  -  -  -  -  -  -  -  -
    ///  z   -  -  -  -  -  z  z  z
    ///  x   -  x  x  x  x  x  x  x
    ///  v   -  x  x  x  x  x  x  x 
    ///  v   -  x  x  x  x  x  x  x 
    ///  y   -  x  x  xy xy xy xy xy
    ///  z   -  x  x  xy xy xyz xyz xyz
    ///  w   -  x  x  xy xy xyz xyz xyzw
    /// 
    /// time: O(nm * min(n,m))
    /// spce: O(nm * min(n,m))
    /// </summary>
    
    char[] expected = {'X', 'Y', 'Z', 'W'};
    LongestCommonSubsequence("ZXVVYZW", "XKYKZPW").Dump();
}

public static List<char> LongestCommonSubsequence (string str1, string str2)
{
    int [,] lengths = new int [str2.Length + 1, str1.Length + 1];

    for (int i = 1; i < str2.Length + 1; i++)
    {
        for (int j = 1; j < str1.Length + 1; j++)
        {
            if (str2 [i - 1] == str1 [j - 1])
            {
                lengths [i, j] = lengths [i - 1, j - 1] + 1;
            }
            else
            {
                lengths [i, j] = Math.Max (lengths [i - 1, j], lengths [i, j - 1]);
            }
        }
    }
    return buildSequence (lengths, str1);
}

public static List<char> buildSequence (int [,] lengths, string str)
{
    List<char> sequence = new List<char> ();
    int i = lengths.GetLength (0) - 1;
    int j = lengths.GetLength (1) - 1;
    while (i != 0 && j != 0)
    {
        if (lengths [i, j] == lengths [i - 1, j])
        {
            i--;
        }
        else
        {
            if (lengths [i, j] == lengths [i, j - 1])
            {
                j--;
            }
            else
            {
                sequence.Insert (0, str [j - 1]);
                i--;
                j--;
            }
        }
    }
    return sequence;
}
// Define other methods, classes and namespaces here
