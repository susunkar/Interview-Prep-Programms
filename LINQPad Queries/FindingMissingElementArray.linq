<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    int[] arr = {4,5,6,7,8,9,10,11,12,14,15,16,18,20};
    FindingMissingNumber(arr).Dump();
    
}
public List<List<int>> FindingMissingNumber(int[] arr){
    List<List<int>> element = new List<System.Collections.Generic.List<int>>();
    int PrevDiff= 0;
    for(int idx= 0; idx<arr.Length; idx++){
        
        int temp = arr[idx] - idx;
        if(idx == 0){
            PrevDiff = temp;
            continue;
        }
        else{
            if(PrevDiff != temp){
                int idxDiff = Math.Abs (temp - PrevDiff);
                PrevDiff = temp;
                element.Add (new List<int> {idx, arr[idx-1]+idxDiff});
            }
        }
    }
    return element;
}

// Define other methods, classes and namespaces here
