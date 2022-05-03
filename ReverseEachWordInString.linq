<Query Kind="Program" />

void Main()
{
	ReverseSring(" ").Dump();
	ReverseSring(null).Dump();
	ReverseSring("My name is Sursh Kumar. S").Dump();
	ReverseSring("racer racecer madam").Dump();
	
	string ReverseSring(string input){
		if(string.IsNullOrEmpty(input)) return input;
		
		System.Text.StringBuilder  d = new StringBuilder(input.Length);
		
		foreach (var tem in input.Split(" ")){
			char [] t = tem.ToCharArray();
			Array.Reverse(t);
			d.Append(new String(t));
			d.Append(" ");
		}
		return d.ToString().Trim();
		
	}
}

// You can define other methods, fields, classes and namespaces here
