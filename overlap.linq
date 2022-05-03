<Query Kind="Program" />

void Main()
{
	int[][] intervals1 = new int[][] {
		new int[] {1, 3},
		new int[] {2, 6},
		new int[] {8, 10},
		new int[] {15, 18}
	};
	int[][] intervals2 = new int[][] {
		new int[] {1,4},
		new int[] {0,5}
	};
	int[][] intervals3 = new int[][] {
		new int[] {1,4},
		new int[] {0,0}
	};
	int[][] intervals6 = new int[][] {
		new int[] {1,4},
		new int[] {0,1}
	};
	int[][] intervals4 = new int[][] {
				new int[] { 2, 3},
				new int[] {4,5},
				new int[] {6,7},
				new int[] {8,9},
				new int[] {1,10} };

	int[][] intervals5 = new int[][] {
new int[] {115,121},new int[] {319,325},new int[] {30,37},new int[] {95,101},new int[] {445,452},new int[] {125,126},new int[] {172,172},new int[] {29,32},new int[] {443,452},new int[] {465,466},new int[] {420,424},new int[] {79,84},new int[] {203,206},new int[] {352,352},new int[] {472,479},new int[] {214,221},new int[] {124,127},new int[] {326,330},new int[] {253,254},new int[] {351,359},new int[] {359,367},new int[] {281,284},new int[] {188,190},new int[] {86,89},new int[] {321,322},new int[] {106,110},new int[] {237,243},new int[] {359,359},new int[] {431,432},new int[] {353,357},new int[] {99,106},new int[] {343,348},new int[] {452,461},new int[] {229,234},new int[] {91,93},new int[] {255,257},new int[] {112,120},new int[] {185,188},new int[] {51,55},new int[] {136,140},new int[] {27,30},new int[] {318,323},new int[] {281,281},new int[] {57,59},new int[] {241,243},new int[] {116,118},new int[] {181,183},new int[] {119,123},new int[] {481,482},new int[] {191,195},new int[] {485,494},new int[] {78,86},new int[] {39,45},new int[] {103,103},new int[] {240,249},new int[] {167,174},new int[] {334,341},new int[] {384,389},new int[] {367,371},new int[] {328,329},new int[] {56,62},new int[] {5,13},new int[] {460,465},new int[] {224,228},new int[] {178,185},new int[] {70,73},new int[] {418,427},new int[] {113,121},new int[] {117,123},new int[] {400,407},new int[] {308,317},new int[] {476,478},new int[] {257,260},new int[] {110,116},new int[] {7,7},new int[] {437,442},new int[] {438,443},new int[] {5,14},new int[] {420,421},new int[] {193,201},new int[] {201,204},new int[] {113,122},new int[] {412,419},new int[] {429,438},new int[] {443,443},new int[] {238,239},new int[] {249,256},new int[] {246,254},new int[] {280,288},new int[] {335,344},new int[] {498,502},new int[] {54,60},new int[] {419,421},new int[] {335,344},new int[] {493,501},new int[] {289,293},new int[] {292,295},new int[] {166,172},new int[] {482,487},new int[] {438,443},new int[] {277,285}
	};
	Merge(intervals5).Dump();

	int[][] Merge(int[][] intervals)
	{
		Array.Sort(intervals, (a, b) => Comparer.Default.Compare(a[0], b[0]));
		List<int[]> merged = new List<int[]>();

		foreach (int[] arr in intervals)
		{
			
			if (merged.Count == 0 || IsInputsAreIN(merged.Last()[0] , merged.Last()[1] ,arr[0], arr[1])){
				merged.Add(arr);
			}
			else {
				merged.Last()[0] = Math.Min(merged.Last()[0], arr[0]);
				merged.Last()[1] = Math.Max(merged.Last()[1], arr[1]);
			}
			//arr.Dump();
			//merged.Last()?.Dump();
		}
		return merged.ToArray();
	}
	bool IsInputsAreIN(int st, int ed, int st1, int ed1)
	{
		//Console.WriteLine($"{st} {ed} {st1} {ed1}");
		//true for new entry
		if(st1>ed) return true;
		else if( ed1<st) return true;
		return false;
		
		//false for merge
		
	}

}






// You can define other methods, fields, classes and namespaces here