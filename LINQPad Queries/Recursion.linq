<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	int r = factorial (5);
	r.Dump();

	int[] a = {1,2,3};
	int s = Sum(a, a.Length-1);
	s.Dump();

	int[] a1 = { 1, 2, 3 };
	int ss = SumV2(a1);
	ss.Dump();


}
public int factorial(int number){
	
	if(number == 0 )
		return 1;
	
	int r = number * factorial(number -1);
	
	return r;
}

public int Sum(int[] a, int lenght){
	if(lenght < 0)
		return 0;
	
	int r = 0;
	r = a[lenght] + Sum(a,lenght -1);
	return r;
}
public int SumV2(int[] a)
{
	if (a.Length ==0)
		return 0;
	int r = 0;
	r = a[0] + SumV2(a.Skip(1).ToArray());
	return r;
}

public string ReversString(string input)
{
	string rev = "";

	if(input.Length==0)
		return input;
		
	rev = input[input.Length-1] + ReversString(input.Substring(0,input.Length-1));
	return rev;
}
public string ReversStringV2(string input)
{
	if(input.Length==0)
		return "";//juest break
	
	return input[input.Length-1]+ ReversStringV2(input.Substring(0,input.Length-1));
}

// Define other methods and classes here