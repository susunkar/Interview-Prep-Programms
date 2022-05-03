<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /*
        n = 5
        k = 6
        arr = [1, 2, 3, 4, 3]
        output = 2
        
        n = 5
        k = 6
        arr = [1, 5, 3, 3, 3]
        output = 4
    */
    int[] array = { 1, 2, 3, 4, 3 };
    int result = numberOfWays (array, 6);
    Console.WriteLine ("Count: {0}", result);
}

private static int numberOfWays (int[] arr, int k)
{
   Dictionary<int,int> hm = new Dictionary<int, int>(); 
   foreach(var e in arr){
       if(hm.ContainsKey(e)){
           hm[e] = hm[e] +1; 
       }
       else {
           hm.Add(e,1);
       }
   }
   int count = 0 ;
   foreach(var e in arr){
       var diff = Math.Abs(k - e);
       
       if(hm.ContainsKey(diff) ){
          count = count + hm[diff];
       }
       if(diff == e){
           count --;
       }
   }
    
   count.Dump();
   
    return count/2;
}
// Define other methods, classes and namespaces here
