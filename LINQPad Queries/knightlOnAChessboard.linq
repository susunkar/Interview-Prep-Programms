<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    knightlOnAChessboard(5).Dump();
}
static int[][] knightlOnAChessboard (int n)
{
    int[][] ret = new int [n - 1] [];
    for(int r = 0;r<ret.GetLength(0);r++){
        ret[r] = new int[n-1];
    }


    for (int r = 1; r < n; r++)
    {
        for (int c = 1; c < n; c++)
        {
            if (ret [c - 1] [r - 1] != 0)
            {
                ret [r - 1] [c - 1] = ret [c - 1] [r - 1];
                continue;
            }

            if (ret [r - 1] [c - 1] == 0)
            {
                ret [r - 1] [c - 1] = move (n, r, c);
            }
        }
    }

    return ret;
}

private static int move (int n, int a, int b)
{
    int[] rd = new int[] { b, a, b, a, -a, -b, -a, -b };
    int[] cd = new int[] { a, b, -a, -b, b, a, -b, -a };

    int[,] visit = new int [n,n];
    int er = n - 1;
    int ec = n - 1;

    Queue<int[]> q = new Queue<int[]>();
    q.Enqueue (new int[] { 0, 0, 0 });
    visit [0,0] = 1;

    while (q.Count>0)
    {
        int[] cur = q.Dequeue();

        if (cur [0] == er && cur [1] == ec)
        {
            return cur [2];
        }

        for (int i = 0; i < 8; i++)
        {
            int nr = rd [i] + cur [0];
            int nc = cd [i] + cur [1];

            if (nr >= 0 && nr < n && nc >= 0 && nc < n && visit [nr,nc] == 0)
            {
                q.Enqueue(new int[] { nr, nc, cur [2] + 1 });
                visit [nr,nc] = 1;
            }
        }
    }

    return -1;
}
// Define other methods, classes and namespaces here
