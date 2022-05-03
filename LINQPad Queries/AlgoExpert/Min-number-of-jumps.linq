<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Min number of jumps (dyanmic programm)
    /// 
    /// O(n) time | O(1) space
    /// 
    /// {"array": [3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3]} jump 4
    /// {"array": [1, 1, 1]} jump 2
    /// {"array": [3, 12, 2, 1, 2, 3, 7, 1, 1, 1, 3, 2, 3, 2, 1, 1, 1, 1]} jump 5
    /// {"array": [2, 1, 2, 2, 1, 1, 1]} jump 4
    /// </summary>
    
    int[] input = {3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3};
    (MinNumberOfJumps(input) == 4).Dump();
}
public static int MinNumberOfJumps (int[] array)
{
    if (array.Length == 1)
    {
        return 0;
    }
    int jumps = 0;
    int maxReach = array [0];
    int steps = array [0];

    for (int i = 1; i < array.Length - 1; i++)
    {
        maxReach = Math.Max (maxReach, i + array [i]);
        steps--;
        if (steps == 0)
        {
            jumps++;
            steps = maxReach - i;
        }
    }
    return jumps + 1;
}
// Define other methods, classes and namespaces here
