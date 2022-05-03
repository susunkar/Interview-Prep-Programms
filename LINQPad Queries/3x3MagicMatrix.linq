<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    int[][] s = new int[3][]{
        new int[3]{5 ,3,4},
        new int[3]{1,5,8},
        new int[3]{6,4,2}
    };

   
    
   formingMagicSquare(s);
}
static int formingMagicSquare (int[][] s)
{
    int[][][] magic_mat =
    {
            new int[][]
            {
                new int[] {8, 1, 6},
                new int[] {3, 5, 7},
                new int[] {4, 9, 2}
            },
            new int[][]
            {
                new int[] {6, 1, 8},
                new int[] {7, 5, 3},
                new int[] {2, 9, 4}
            },
            new int[][]
            {
                new int[] {4, 9, 2},
                new int[] {3, 5, 7},
                new int[] {8, 1, 6}
            },
            new int[][]
            {
                new int[] {2, 9, 4},
                new int[] {7, 5, 3},
                new int[] {6, 1, 8}
            },
            new int[][]
            {
                new int[] {8, 3, 4},
                new int[] {1, 5, 9},
                new int[] {6, 7, 2}
            },
            new int[][]
            {
                new int[] {4, 3, 8},
                new int[] {9, 5, 1},
                new int[] {2, 7, 6}
            },
            new int[][]
            {
                new int[] {6, 7, 2},
                new int[] {1, 5, 9},
                new int[] {8, 3, 4}
            },
            new int[][]
            {
                new int[] {2, 7, 6},
                new int[] {9, 5, 1},
                new int[] {4, 3, 8}
            }
        };

    int min_cost = int.MaxValue;
    for (int k = 0; k < 8; k++)
    {
        int crt_cost = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                crt_cost += Math.Abs (s[i] [j] - magic_mat [k] [i] [j]);
            }
        }
        if (crt_cost < min_cost)
        {
            min_cost = crt_cost;
        }
    }

    Console.Write ("{0:D}", min_cost);
    return min_cost;
}

// You can define other methods, fields, classes and namespaces here
