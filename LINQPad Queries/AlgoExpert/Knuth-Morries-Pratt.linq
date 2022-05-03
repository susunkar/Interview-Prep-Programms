<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Knuth-Morries-Pratt Algorithm 
    /// time : O(n+m)
    /// 
    /// "string": "abxabcabcaby", "substring": "abcaby"
    /// "string": "decadaafcdf", "substring": "daf"
    /// </summary>
    string str = "aefoaefcdaefcdaed";
    string substring =  "aefcdaed";
    
    KnuthMorrisPrattAlgorithm(str,substring).Dump();
    
}
public static bool KnuthMorrisPrattAlgorithm (string str, string substring)
{
    int[] pattern = buildPattern (substring);
    return doesMatch (str, substring, pattern);
}

public static int[] buildPattern (string substring)
{
    int[] pattern = new int [substring.Length];
    Array.Fill (pattern, -1);

    int i = 1;
    int j = 0;

    while (i < substring.Length)
    {
        if (substring [i] == substring [j])
        {
            pattern [i] = j;
            i++;
            j++;
        }
        else
        {
            if (j > 0)
            {
                j = pattern [j - 1] + 1;
            }
            else
            {
                i++;
            }
        }
    }
    return pattern;
}

public static bool doesMatch (string str, string substring, int[] pattern)
{
    int i = 0;
    int j = 0;

    while (i + substring.Length - j <= str.Length)
    {
        if (str [i] == substring [j])
        {
            if (j == substring.Length - 1)
            {
                return true;
            }
            i++;
            j++;
        }
        else
        {
            if (j > 0)
            {
                j = pattern [j - 1] + 1;
            }
            else
            {
                i++;
            }
        }
    }
    return false;
}
// Define other methods, classes and namespaces here
