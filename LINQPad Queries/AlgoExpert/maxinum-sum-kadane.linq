<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <Namespace>Xunit</Namespace>
  <Namespace>Xunit.Abstractions</Namespace>
  <Namespace>Xunit.Extensions</Namespace>
  <Namespace>Xunit.Sdk</Namespace>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// The maxinum sum that can be obtained by summing up all of the integers in input array
    /// Kadane's algorithm (Dynamic problem)
    /// [3,5,-9,1,3,-2,3,4,7,2,-9,6,3,1,-5,4]
    ///         ^                     ^  
    /// sum 19
    /// </summary>

    int[] input = { 3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4 };
    Xunit.Assert.True(KadanesAlgorithm (input) == 19,"Pass".Dump());

}
public static int KadanesAlgorithm(int[] array){
   int maxEndingHere = array[0];
    int maxSoFar = array[0];
    
    for(int i=1; i<array.Length; i++){
        int num = array[i];
        maxEndingHere = Math.Max(num, maxEndingHere + num);
        maxSoFar = Math.Max(maxSoFar, maxEndingHere);
    }
    return maxSoFar;
}

// Define other methods, classes and namespaces here
