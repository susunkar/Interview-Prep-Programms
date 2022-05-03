<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Levenshtein Distance Dynamic programming
    /// function that takes in two strings and returns the minimum number of edit operations that need to be performed on the first string to obtain the second string.
    /// str1 : "abc" is input
    /// str2 : "yabd" is output, two operation y is inserted and c substitute
    /// 
    ///     "", y, a, b, d
    /// "",  0, 1, 2, 3, 4
    ///  a,  1, 1, 1, 2, 3 
    ///  b,  2, 2, 2, 1, 2
    ///  c,  3, 3, 3, 2, 2
    /// 
    /// if(str1[r] == str2[c]):
    ///     E[r,c] = E[r-1,c-1] //diagonal
    /// else:
    ///     E[r,c] = 1 + min(E[r,c-1], E[r-1,c], E[r-1,c-1])
    /// </summary>
    ///     y, a, b, d
    ///  a, 1, 1, 2, 3 
    ///  b, 2, 2, 1, 2
    ///  c, 3, 3, 2, 2
    /// 
    /// if(str1[r] == str2[c]):
    ///     E[r,c] = E[r-1,c-1] //diagonal
    /// else:
    ///     E[r,c] = 1 + min(E[r,c-1], E[r-1,c], E[r-1,c-1])
    /// 
    /// Time: O(N*M)
    /// Space: O(N*M)
    /// </summary>

    (LevenshteinDistance ("abc", "yabd") == 2).Dump();
}
//O(nm) time | O(nm) space
public static int LevenshteinDistance (string str1, string str2)
{
    int [,] edits = new int [str2.Length + 1, str1.Length + 1];
    for (int i = 0; i < str2.Length + 1; i++)
    {
        for (int j = 0; j < str1.Length + 1; j++)
        {
            edits [i, j] = j;
        }
        edits [i, 0] = i;
    }
    for (int i = 1; i < str2.Length + 1; i++)
    {
        for (int j = 1; j < str1.Length + 1; j++)
        {
            if (str2 [i - 1] == str1 [j - 1])
            {
                edits [i, j] = edits [i - 1, j - 1];
            }
            else
            {
                edits [i, j] = 1 + Math.Min (edits [i - 1, j - 1], Math.Min (edits [i - 1, j], edits [i, j - 1]));
            }
        }
    }
    edits.Dump();
    return edits [str2.Length, str1.Length];
}


// Define other methods, classes and namespaces here
