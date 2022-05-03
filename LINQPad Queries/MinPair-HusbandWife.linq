<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    //int[] row = new int[] {5,3,4,2,1,0};//Expected 1
    //int[] row = new int[] {2,0,5,4,3,1};//Expected 1
    //int[] row = new int[] {0, 2, 1, 3};//Expected 1
    //int[] row = new int[] {3, 2, 0, 1};//Expected 0
    //int[] row = new int[] { 5, 4, 2, 6, 3, 1, 0, 7};//Expected 2

    int[] row = new int[] { 6, 2, 1, 7, 4, 5, 3, 8, 0, 9};//Expected 3
    
    Solution sl = new Solution();
    
    sl.MinSwapsCouples(row).Dump();
    
}
public class Solution
{
    
    public int MinSwapsCouples (int[] row)
    {
        Dictionary<int, int> positionValue = new Dictionary<int, int>();
        for (int i = 0; i < row.Length; i++)
        {
            positionValue.Add (row [i], i );
        }
        int firstElement = Int32.MinValue;
        int secondElement = Int32.MinValue;
        
        int swaps = 0;
        
        for(int i=0; i<row.Length; i++){
            
            if(firstElement == Int32.MinValue){
                firstElement= row[i];
            }
            else{
                secondElement = row[i];
                if(firstElement/2 == secondElement/2){
                    firstElement = Int32.MinValue;
                    secondElement = Int32.MinValue;
                }
                else{
                    swaps++;
                    var required = Int32.MinValue;
                    if(firstElement%2 == 0){
                        required= firstElement +1;
                    }
                    else{
                        required= firstElement -1;
                    }
                    
                    var locationOfRequired = positionValue[required];
                    var temp = row[i];
                    
                    row[i] = row[locationOfRequired];
                    row[locationOfRequired]= temp;
                    
                    positionValue[row[i]] =i;
                    positionValue[row[locationOfRequired]] = locationOfRequired;
                    
                    firstElement=Int32.MinValue;
                    secondElement=Int32.MinValue;
                }
            }
        }
        return swaps;
    }
}
// Define other methods, classes and namespaces here
