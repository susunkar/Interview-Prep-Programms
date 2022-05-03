<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{

	//Euclid's Algorithm
	//GCD Greatest Common Divisior
	
	//var R = GCD(7,2);
	//R.Dump();
	
	
	//Calculating LCM with CDG
	/*
		LCM(x,y) = (x*y)/CGB(x,y) => (x/GCB(x,y)) * y
	*/
	var lcm = LCM(12,15);
	lcm.Dump();
	
	
	//Prime number
	//PrimeFactor(15);
}
public int GCD (int a, int b){
	while (b !=0)
	{
		var remainder = a % b;
		
		a=b;
		b=remainder;
		
	}
	return a;
}

public int LCM(int x,int y){
	
	var r = (x/GCD(x,y))*y;
	return r;
}

public void PrimeFactor(int number){
	int a = 2;
	do{
		var c = number %a;
		if(c==0)
		{
			Console.WriteLine("{0}", a);
			number = number / a;
		}
		else {
			++a;
		}
	}while(number >= a);
}



// Define other methods and classes here