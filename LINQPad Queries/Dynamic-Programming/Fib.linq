<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <Namespace>System.Threading.Tasks</Namespace>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    fib(7).Dump("Recursing");//0,1,1,2,3,5,8,13,21
    fibMemo(7).Dump("Recursing Memo");
    fibBottomUp(7).Dump("BottomUp");
}
public static int fib(int num){
    if (num == 0 || num == 1) return 1;
    int result = fib(num -1) + fib(num -2);
    return result;
}
// Dynamic programming with Memo/Topdown 
public static int fibMemo(int num, List<int> cache=null){
    if(num == 0 || num == 1) return 1;

    if (cache == null) cache = new List<int> () {0,1};
    
    if(num < cache.Count) return cache[num];
    
    int r =  (fibMemo(num - 1, cache) + fibMemo(num - 2, cache));
    cache.Add(r);
    return r;
}
// Dynamic programming with Bottom-Up approch with min memori utilization
public static int fibBottomUp(int num){
    int a = 0;
    int b = 1;
    
    for(int i = 1; i<=num;i++){
        int c = a+b;
        a = b;
        b = c;
       
    }
    return b;
}
// You can define other methods, fields, classes and namespaces here
