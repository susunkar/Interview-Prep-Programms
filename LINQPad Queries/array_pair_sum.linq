<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /*
        ƒ(10, [3, 4, 5, 6, 7]) -> [(4, 6), (3, 7)]
        ƒ( 8, [3, 4, 5, 4, 4]) -> [(3, 5)]
    */
    int[] array = new int[] {3, 4, 5, 6, 7,5};
    int target = 10;
    var result = array_pair_sum(array,target);
    result.Dump();
}
 public List<(int x, int y)> array_pair_sum(int[] array, int target){
    
    var seen = new HashSet<int>();
    var pairs = new List<(int x, int y)>();
    
    for (int i = 0; i < array.Length; i++)
    {
        var n = array [i];
        var diff = target - n;
        if (diff != n)
        {
            if (seen.Contains (diff))
            {
                pairs.Add ((Math.Min (diff, n), Math.Max (diff, n)));
            }
            else
            {
                seen.Add (n);
            }
        }
    }
     
     return pairs;
 } 

// Define other methods, classes and namespaces here
