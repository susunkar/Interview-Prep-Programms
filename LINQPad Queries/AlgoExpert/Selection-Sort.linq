<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    int[] expected = { 2, 3, 5, 5, 6, 8, 9 };
    int[] input = { 8, 5, 2, 9, 5, 6, 3 };
    Xunit.Assert.True (Enumerable.SequenceEqual(SelectionSort (input), expected),"Pass".Dump());
}
public static int[] SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array [i] > array [j])
            {
                //swap
                var temp = array [j];
                array [j] = array [i];
                array [i] = temp;

            }
        }
    }
    return array;
}
// Define other methods, classes and namespaces here
