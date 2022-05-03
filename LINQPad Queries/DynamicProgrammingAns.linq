<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int n = 2;
	List<List<int>> q = new List<System.Collections.Generic.List<int>>(){
		new List<int>(){1, 0, 5},
		new List<int>(){1, 1, 7},
		new List<int>(){1, 0, 3},
		new List<int>(){2, 1 ,0},
		new List<int>(){2, 1, 1}
	};
	
	var r = dynamicArray(n,q);
	r.Dump();
}
public static List<int> dynamicArray(int n, List<List<int>> queries)
{
	int lastAnswer = 0;
	List<List<int>> seq = new List<System.Collections.Generic.List<int>>();
    List<int> res = new List<int>();
    
	for (int i =0 ; i<n;i++){
		seq.Add(new List<int>());
	}
	
    foreach (var l in queries){
        var index = (l[1] ^ lastAnswer) %n ;
    
        if(l[0] == 1){
            seq[index].Add(l[2]);
        }
		else
		{
			var position = l[2] % seq[index].Count;
			lastAnswer = seq[index][position];
			res.Add(lastAnswer);
		}
	}
	return res;
}
// Define other methods, classes and namespaces here
