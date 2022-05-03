<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	string usreInput = "GGRBRBBGRBR";
	var inp = usreInput.ToArray();
	int l = 0;
	int i = 0;
	int h = usreInput.Length-1;
	while (i <=h){
		if (inp[i] == 'R'){
			char t = inp[l];
			inp[l] = inp[i];
			inp[i] = t;
			i++;
			l++;
		}
		else if(inp[i] == 'B'){
			char t = inp[h];
			inp[h] = inp[i];
			inp[i] = t;
			h--;
		}
		else {
			i++;
		}
	}
	usreInput.Dump();
	inp.Dump();
}

// Define other methods, classes and namespaces here