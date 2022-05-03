<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	int[] a = new int[] {  7, 6};
	int[] b = new int[] {  1, 7};
	AddingArrayNumbers(a,b).Dump();
}

public int[] AddingArrayNumbers(int[]a,int[]b)
{
	int endloop = 0;
	int carray = 0;
	int[] result ;
	int tempa= 0, tempb=0;
	
	if(a.Length >= b.Length){
		endloop = a.Length;
		result = new int[a.Length+1];
	}
	else {
		endloop = b.Length;
		result = new int[b.Length+1];
	}
	for (int i = 1; i<=endloop ;i++){
		tempa= tempb =0;
		if(a.Length-i >=0 && a.Length-i < a.Length){
			tempa = a[a.Length-i];
		}
		if(b.Length-i >=0 && b.Length-i < b.Length)
		{
			tempb = b[b.Length-i];
		}
		
		var  sum = carray + tempa + tempb;
		carray =0;
		if(sum >=10)
		{
			carray = sum /10;
			sum = sum % 10;
		}
		result[result.Length-i] = sum;
	}
	result[0] =carray; 
	return result;
}
// Define other methods and classes here
