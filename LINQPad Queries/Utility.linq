<Query Kind="Program" />

void Main()
{
	sizeof(int).Dump("int");
	sizeof(long).Dump("int");
	sizeof(char).Dump("char");
	sizeof(float).Dump("float");
	sizeof(double).Dump("double");
	sizeof(Int32).Dump("int32");

	char l = '\n';

	Console.WriteLine("{0}", (int)l);
	string s =  "ABC";
	var codeUp = (int)s[0]+321;
	var low = (char)codeUp;
	char spc = '\0';
	spc.Dump();
	low.Dump();
	
	var start = (int) 'a';
	start.Dump();
	var r = (int) 'd';
	r.Dump();
//******************************
	int[] row = Enumerable.Repeat(-1,5).ToArray();
	int[] col = Enumerable.Repeat(-1,5).ToArray();

	int[][] jagged = new int[3][];

	jagged[0] = new int[] { 1, 2, 3, 4 }; //0th index hold the new arry[5]
	jagged[1] = new int[] { 1, 2 }; //1th index hold the new arry[2]
	jagged[2] = new int[] { 1, 2, 3 }; //2th index hold the new arry[3]

	for(int i=0; i<jagged.Length;i++)
	{
		for(int j =0 ;j<jagged[i].Length;j++)
			Console.Write(" " + jagged[i][j]);
		
		Console.WriteLine();
	}

	int[,] multidim = new int[3, 6] {
		{1,2,3,4,5,6},
		{1,2,3,4,5,6},
		{1,2,3,4,5,6}
	};
	for (int i = 0; i < multidim.GetLength(0); i++)
	{
		for (int j = 0; j < multidim.GetLength(1); j++)
			Console.Write(" " + multidim[i,j]);

		Console.WriteLine();
	}
    //******************************
    Enumerable.SequenceEqual (new List<int> () { 2, 3, 4 }, new List<int> () { 2, 3, 4 }).Dump();

    int[] array = Enumerable.Range (1, 10).ToArray();
    array.Dump();//1,2,3,4,5,6,7,8,9,10

    Random rndgenerator = new Random();
    int rnd = rndgenerator.Next (1, 10);
    rnd.Dump();

    int[] test2 = Enumerable
     .Repeat (0, 5)
     .Select (i => rndgenerator.Next (1, 30))
     .ToArray();
    test2.Dump();
}

// Define other methods and classes here