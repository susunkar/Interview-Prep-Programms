<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	string s ="aba";
	long n =10;

	long scount = 0;

	foreach (char c in s.ToArray())
	{
		if (c == 'a')
		{
			scount++;
		}
	}
	
	var s_occurrences_qty = n/s.Length;
	var s_occurrences_left = n - (s_occurrences_qty * s.Length);
	var s_left = s.Substring( 0, (int) s_occurrences_left);


	var a_occurrences_in_s_left = 0;
	foreach (char c in s_left.ToArray())
	{
		if (c == 'a')
		{
			a_occurrences_in_s_left++;
		}
	}
	
	var r = (scount * s_occurrences_qty) + a_occurrences_in_s_left;

}

// Define other methods, classes and namespaces here