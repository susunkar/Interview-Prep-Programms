<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>


public class solution
{
    static void Main()
    {
        int[] a = {1,2,3};
        Permute(a).Dump();
    }
    public static List<List<int>> Permute (int[] nums){
        List<int> tmpList = new List<int>();
        List<List<int>> result = new List<System.Collections.Generic.List<int>>();
        
        backtrack(nums,tmpList, result,1);
        return result;
    }

    private static void backtrack (int [] nums, List<int> tmpList, List<List<int>> result, int call)
    {
        call.Dump("Call");
       // display(tmpList,call,"Start");
        if(tmpList.Count == nums.Length){
            result.Add(tmpList.ToList());
            return;
        }
        foreach(var num in nums){
            if(tmpList.Contains(num)){
                continue;
            }
           
            tmpList.Add(num);
            display(tmpList,call,"Start");
            backtrack(nums,tmpList,result, call++);
            display(tmpList, call,"End");
            tmpList.RemoveAt(tmpList.Count-1);
        }
    }

    private static void display (List<int> tmpList,int call,string s)
    {
        Console.WriteLine ($"{call} - {s}");
        foreach (int e in tmpList)
        {
            Console.Write ($"{e}, ");
        }  
        Console.WriteLine();
    }
}


// Define other methods, classes and namespaces here
