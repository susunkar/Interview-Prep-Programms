<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	int[,] a = new int[3,3]{
	 { 1,2,3 },
	 { 4,5,6},
	 { 7,8,9},
	};

//foreach (var row in a)
//{
//	foreach(var col in row)
//		Console.Write(col + " ");
//	Console.WriteLine();
//}
	
a.Dump();
	
	int size = a.GetLength(0);
	for(int x=0;x<size;x++)
	{
         Console.WriteLine ($"x:{x}");
		for(int y = x; y< size-x-1; y++){
			int nx = size-1-x;
			int ny= size-1-y;

            Console.WriteLine ($"y:{y}");
            Console.WriteLine ($"nx:{nx}  ny:{ny}");
            
			int swapVal = a[x,y];
			a[x,y] = a[ny,x];
			a[ny,x] = a[nx,ny];
			a[nx,ny] = a[y,nx];
			a[y,nx] = swapVal;
            a.Dump();
		}
	}
a.Dump();
}

// Define other methods and classes here
