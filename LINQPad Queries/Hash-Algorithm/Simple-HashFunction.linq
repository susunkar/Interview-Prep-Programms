<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	string input = string.Empty;
	
	while(!input.Equals("quit",StringComparison.OrdinalIgnoreCase))
	{
		input = Console.ReadLine();

		Console.WriteLine("Additive: {0}", AdditiveHash(input));
		Console.WriteLine("Folding: {0}", FoldingHash(input));
		Console.WriteLine("DJB2: {0}", Djb2Hash(input));
	}
}

public static int AdditiveHash(string input)
{
	int currentHashValue = 0;
	
	foreach (char c in input)
	{
		unchecked{
			currentHashValue +=(int)c;
		}
	}
	
	return currentHashValue;
}

public static int FoldingHash(string input){
	int hashValue = 0;
	int startingIndex = 0;
	int currentFourBytes;
	
	do{
		currentFourBytes = GetNextBytes(startingIndex, input);
		unchecked
		{
			hashValue +=currentFourBytes;	
		}
		startingIndex +=4;
	}while(currentFourBytes !=0);
	
	return hashValue;
}

public static int  Djb2Hash(string input)
{
	int hash = 5381;
	foreach (char c in input)
	{
		unchecked
		{
			hash = ((hash<<5)+hash)+(int)c;
		}
	}

	return hash;
}

public static int GetNextBytes(int startingIndex, string input){
	int currentFourByets = 0;

	currentFourByets += GetByte(input, startingIndex);
	currentFourByets += GetByte(input, startingIndex+1) << 8;
	currentFourByets += GetByte(input, startingIndex+2) << 16;
	currentFourByets += GetByte(input, startingIndex+3) << 24;

	return currentFourByets;
}

public static int GetByte(string input, int startingIndex){
	if(startingIndex < input.Length)
	{
		return (int)input[startingIndex];
	}
	return 0;
}
// Define other methods and classes here