<Query Kind="Program" />

void Main()
{
	//factorial(n) = n * facrorial(n-1);
	
	factorial(5).Dump();
	factorial(4).Dump();
	factorial(3).Dump();
	factorial(2).Dump();
	factorial(1).Dump();
}

public int factorial(int v)
{
	if(v == 1) return 1;
	return v * factorial (v-1);
}

// You can define other methods, fields, classes and namespaces here