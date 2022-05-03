<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Number of Ways to Make change Dyanamic program
    /// {"denoms": [1, 5], "n": 6} output: 2
    /// {"denoms": [5], "n": 9} output : 0
    /// {"denoms": [2, 4], "n": 7} output: 0
    /// {"denoms": [1, 5, 10, 25], "n": 5} output : 2
    /// </summary>
    /// 

}
public static int NumberOfWaysToMakeChange (int n, int[] denoms)
{
    int [] ways = new int [n+1];
    ways[0] = 1; 
    foreach(int denom in denoms){
        for(int amount = 1; amount < n+1 ;amount++){
            if(denom <=amount){
                ways[amount] += ways[amount - denom];
            }
        }
    }
    return ways[n];
}
// Define other methods, classes and namespaces here
