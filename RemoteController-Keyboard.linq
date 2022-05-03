<Query Kind="Program" />

void Main()
{
	var KybLayout = GetKybLayout();
	string InputString ="SQUID";
	string result = string.Empty;
	int row =1;
	int col =1;
	foreach (var c in InputString)
	{
		if (!KybLayout.ContainsKey(c))
		{
			continue;
		}
		else {
			var targetIdxs = KybLayout[c];
			var temp = GetPathfromCurrentToTarget(row,col, targetIdxs);
			row = targetIdxs[0,0];
			col= targetIdxs[0,1];
			Console.WriteLine(temp);
			result+=temp;
		}
	}
	result.Dump();
}

string GetPathfromCurrentToTarget(int row, int col, int[,] targetIdxs)
{
	int tarRow = targetIdxs[0,0];
	int tarCol = targetIdxs[0,1];
	string tempPath = string.Empty;
	if(row<tarRow){
		int temp = Math.Abs((row-tarRow));
	    tempPath += string.Join("", Enumerable.Repeat('D',temp));
	}
	else
	{
		int temp = Math.Abs((row - tarRow));
		tempPath += string.Join("", Enumerable.Repeat('U', temp));
	}
	if (col < tarCol)
	{
		int temp = Math.Abs((col - tarCol));
		tempPath += string.Join("", Enumerable.Repeat('R', temp));
	}
	else
	{
		int temp = Math.Abs((col - tarCol));
		tempPath += string.Join("",Enumerable.Repeat('L', temp));
	}
	return tempPath;
}

public Dictionary<char, int[,]> GetKybLayout(){
	var KeyBoard = new Dictionary<char, int[,]>();
	KeyBoard.Add('A', new int[,] { { 1, 1 } });
	KeyBoard.Add('B', new int[,] { { 1, 2 } });
	KeyBoard.Add('C', new int[,] { { 1, 3 } });
	KeyBoard.Add('D', new int[,] { { 1, 4 } });
	KeyBoard.Add('E', new int[,] { { 1, 5 } });
	KeyBoard.Add('F', new int[,] { { 1, 6 } });
	KeyBoard.Add('G', new int[,] { { 1, 7 } });
	KeyBoard.Add('H', new int[,] { { 2, 1 } });
	KeyBoard.Add('I', new int[,] { { 2, 2 } });
	KeyBoard.Add('J', new int[,] { { 2, 3 } });
	KeyBoard.Add('K', new int[,] { { 2, 4 } });
	KeyBoard.Add('L', new int[,] { { 2, 5 } });
	KeyBoard.Add('M', new int[,] { { 2, 6 } });
	KeyBoard.Add('N', new int[,] { { 2, 7 } });
	KeyBoard.Add('O', new int[,] { { 3, 1 } });
	KeyBoard.Add('P', new int[,] { { 3, 2 } });
	KeyBoard.Add('Q', new int[,] { { 3, 3 } });
	KeyBoard.Add('R', new int[,] { { 3, 4 } });
	KeyBoard.Add('S', new int[,] { { 3, 5 } });
	KeyBoard.Add('T', new int[,] { { 3, 6 } });
	KeyBoard.Add('U', new int[,] { { 3, 7 } });
	KeyBoard.Add('V', new int[,] { { 4, 1 } });
	KeyBoard.Add('W', new int[,] { { 4, 2 } });
	KeyBoard.Add('X', new int[,] { { 4, 3 } });
	KeyBoard.Add('Y', new int[,] { { 4, 4 } });
	KeyBoard.Add('Z', new int[,] { { 4, 5 } });
	KeyBoard.Add('-', new int[,] { { 4, 6 } });
	KeyBoard.Add('.', new int[,] { { 4, 7 } });
	return KeyBoard;
	 
}

// You can define other methods, fields, classes and namespaces here