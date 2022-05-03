<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    int[] arr = {203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
    int[] brr = {203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204};
    missingNumbers(arr,brr).Dump();
}
static int[] missingNumbers (int[] arr, int[] brr)
{
    Dictionary<int, int> count = new Dictionary<int, int>();
    int min = 0;
    int max = 0;
    HashSet<int> missinNumber = new HashSet<int>();
    for (int i = 0; i < brr.Length; i++)
    {
        if (count.ContainsKey (brr [i]))
        {
            count [brr [i]] += 1;
        }
        else
        {
            count.Add (brr [i], 1);
        }
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (count.ContainsKey (arr [i]) && count [arr [i]] > 0)
        {
            count [arr [i]] -= 1;
        }
    }
    List<int> result = count.Where(x=>x.Value >0).Select(y=>y.Key).ToList();
    result.Sort();
    return result.ToArray();

}
// Define other methods, classes and namespaces here
