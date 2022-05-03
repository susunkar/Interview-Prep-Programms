<Query Kind="Program" />

void Main()
{
	Dictionary<int,long> HashResult = new Dictionary<int,long>();
	fib(50,HashResult).Dump();
}
long fib(int n,Dictionary<int,long> HashResult){
	if(n<=2) return 1;
	if(HashResult.ContainsKey(n)) return HashResult[n];
	
	HashResult.Add(n, fib(n-1,HashResult) + fib(n-2,HashResult));
	return HashResult[n];
}

