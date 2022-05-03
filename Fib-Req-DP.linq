<Query Kind="Program" />

void Main()
{

	
	Hashtable memoization = new Hashtable();

Fibnthnumber(30).Dump();
Fibnthnumber(40).Dump();
memoization.Dump();
	int Fibnthnumber(int n){
		
		if(memoization.Contains(n)) {
			return (int) memoization[n];
		}
		if(n <=2) return 1;
		
		memoization.Add(n,Fibnthnumber(n-1) + Fibnthnumber(n-2));
		
		return (int) memoization[n];
	}
}

// You can define other methods, fields, classes and namespaces here