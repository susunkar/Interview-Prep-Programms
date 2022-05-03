<Query Kind="Program" />

void Main()
{
	string s= "decimal";
	string a ="medical";
	stringPerm(s.ToArray(),0,s.Length);
}
void stringPerm(char[] s, int l, int h){
	int i ;
	if (l == h)
	{
			Console.WriteLine(s);
	}
	else{
		for(i=l;i<h ;i++)
		{
			swap(s,l,i);
			stringPerm(s,l+1,h);
			swap(s,l,i);
		}
	}
}

void swap(char[] s, int l, int i)
{
	char temp = s[l];
	s[l] = s[i];
	s[i] = temp;
}


// Define other methods and classes here
