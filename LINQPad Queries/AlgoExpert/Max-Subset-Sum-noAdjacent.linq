<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Max Subset Sum no Adjacent element to add (Dynamic programming)
    /// [7,10,12,7,9,14]
    /// 7+12+14 =33
    /// 
    /// formula: 
    /// array : [7,10,12,7,9,14]
    /// MaxSumArray : [7,10,19,19,28,33]
    /// 
    /// max(MaxSumArray[i-1], MaxSumArray[i -2 ] + array[i])
    /// </summary>
    int[] array = new int[] {30,25,50,55,100,120};
    
    MaxSubsetSumNoAdjacent(array);
}
public static int MaxSubsetSumNoAdjacent (int[] array)
{

    if (array.Length == 0)
    {
        return 0;
    }
    else
    {
        if (array.Length == 1)
        {
            return array [0];
        }
    }

    int[] maxSum = new int [array.Length];
    maxSum [0] = array [0];
    maxSum [1] = Math.Max(array [0],array [1]);
        
    for (int i = 2; i < array.Length; i++)
    {
        maxSum [i] = Math.Max (maxSum [i - 1], maxSum [i - 2] + array [i]);
    }
    maxSum.Dump();
    return maxSum [maxSum.Length - 1];
}

// Define other methods, classes and namespaces here
