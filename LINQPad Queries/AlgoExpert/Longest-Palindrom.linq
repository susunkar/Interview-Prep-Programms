<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	//checkPalindrom(null).Dump();
	LongestPalindromicSubstring("abaxyzzyxf").Dump();
	LongestPalindromicSubstring("aaabaaaabaaaaa").Dump();
	LongestPalindromicSubstring("a").Dump();
}

public bool checkPalindrom(string str){
	
	if(str is null)
	{
			"input string is null".Dump();
			return false;
	}
	
	str = str.Replace(" ","");
	int lenght = str.Length-1;
	
	foreach (char element in str.ToLower())
	{
		//element.Dump();
		if(!element.Equals(str.ToLower().ElementAt(lenght--)))
		{
			//"input string is not palandrom".Dump();
			return false;
		}
	}
	return true;
}
public string LongestPalindromicSubstring(string str)
{
	
	if(str.Length== 1){
		return str;
	}
	
	string palinstr ="";

	for (int i =0; i <str.Length-1; i++)
	{
		int j =i;
		
		while(j<str.Length-1){
			
			int t= j+1;
			
			if(str.ElementAt(i) == str.ElementAt(t))
			{	
				string tmp = GetPalintext(str,i,t);
				
				 if(checkPalindrom(tmp) && palinstr.Length < tmp.Length){
					palinstr = tmp;
				 }
			}
			
			j++;
		}
	}
	return palinstr;
}
public string GetPalintext(string str,int start, int end){

	string tem= "";
	while (start <= end)
	{
		tem= tem + str.ElementAt(start);
		start++;
	}
	//tem.Dump();
	return tem;
}

// Define other methods and classes here