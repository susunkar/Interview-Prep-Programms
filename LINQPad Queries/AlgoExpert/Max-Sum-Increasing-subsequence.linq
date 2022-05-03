<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Max Sum Increasing subsequence (Dynamic problem)
    /// [8,12,2,3,15,5,7]
    /// 8 + 12 + 15 = 35
    /// 
    /// sums[8, 20, 2, 5, 35, 8,15] 
    /// 
    /// sequences[none, 0, none, 2, 1
    /// 
    /// currentNum = array [i]
    /// otherNum = array [j]
    /// if otherNum < currentNum And sums[j] + currentNum >= sums[i]
    /// 
    /// time : O(n^2)
    /// space : O(n)
    /// </summary>

    int[] input = { 10, 70, 20, 30, 50, 11, 30 };
    Tuple<int, int[]> expected = Tuple.Create (110, new int[] { 10, 20, 30, 50 });
    MaxSumIncreasingSubsequence (input).Dump();
}

public static List<List<int>> MaxSumIncreasingSubsequence (int[] array)
{
    int[] sequences = new int [array.Length];
    Array.Fill (sequences, Int32.MinValue);

    int[] sums = (int[])array.Clone();
    int maxSumIdx = 0;

    for (int i = 0; i < array.Length; i++)
    {
        int currentNum = array [i];
        for (int j = 0; j < i; j++)
        {
            int otherNum = array [j];
            if (otherNum < currentNum && sums [j] + currentNum >= sums [i])
            {
                sums [i] = sums [j] + currentNum;
                sequences [i] = j;
            }
        }
        if (sums [i] >= sums [maxSumIdx])
        {
            maxSumIdx = i;
        }
    }

    return buildSequence (array, sequences, maxSumIdx, sums [maxSumIdx]);
}

public static List<List<int>> buildSequence (int[] array, int[] sequences, int currentIdx,
    int sums)
{
    List<List<int>> sequence = new List<List<int>>();
    sequence.Add (new List<int>());
    sequence.Add (new List<int>());
    sequence [0].Add (sums);

    while (currentIdx != Int32.MinValue)
    {
        sequence [1].Insert (0, array [currentIdx]);
        currentIdx = sequences [currentIdx];
    }
    return sequence;
}
// Define other methods, classes and namespaces here
