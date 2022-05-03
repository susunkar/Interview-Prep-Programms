<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Max path sum in binary tree 
    ///                1(18)
    ///         2(7,11)    3(10,16)
    ///     4      5     6    7
    ///    (4,4)  (5,5) (6,6)  (7,7)
    /// 
    /// 2+5+1+3+7 = 18
    /// O(N) time | O(log(N)) space
    /// </summary>


    TestBinaryTree test = new TestBinaryTree (1);
    // test.insert (new int[] { 2, 3, 4, 5, 6, 7 }, 0);
    // (MaxPathSum(test) == 18).Dump();

     test.insert (new int[] { 2, 30, 4, 0, 30, 30 }, 0);
     (MaxPathSum(test) ).Dump();//90
}
public static int MaxPathSum (BinaryTree tree)
{
    List<int> maxSumArray = findMaxSum (tree);
    maxSumArray.Dump();
    return maxSumArray [1];
}

public static List<int> findMaxSum (BinaryTree tree)
{
    if (tree == null)
    {
        return new List<int>(){
                    0, Int32.MinValue
                };
    }
    List<int> leftMaxSumArray = findMaxSum (tree.left);
    int leftMaxSumAsBranch = leftMaxSumArray [0];
    int leftMaxPathSum = leftMaxSumArray [1];

    List<int> rightMaxSumArray = findMaxSum (tree.right);
    int rightMaxSumAsBranch = rightMaxSumArray [0];
    int rightMaxPathSum = rightMaxSumArray [1];

    int maxChildSumAsBranch = Math.Max (leftMaxSumAsBranch, rightMaxSumAsBranch);
    int maxSumAsBranch = Math.Max (maxChildSumAsBranch + tree.value, tree.value);
    
    int maxSumAsRootNode = Math.Max (
        leftMaxSumAsBranch + tree.value + rightMaxSumAsBranch,
        maxSumAsBranch
    );
    
    int maxPathSum = Math.Max (leftMaxPathSum, Math.Max (rightMaxPathSum,
            maxSumAsRootNode));
            
    return new List<int>(){
                maxSumAsBranch, maxPathSum
            };
}

public class BinaryTree
{
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree (int value)
    {
        this.value = value;
    }
}


public class TestBinaryTree : BinaryTree
{
    public TestBinaryTree (int value) : base (value)
    {
    }

    public void insert (int[] values, int i)
    {
        if (i >= values.Length)
        {
            return;
        }
        List<BinaryTree> queue = new List<BinaryTree>();
        queue.Add (this);
        var index = 0;
        while (index < queue.Count)
        {
            BinaryTree current = queue [index];
            index += 1;
            if (current.left == null)
            {
                current.left = new BinaryTree (values [i]);
                break;
            }
            queue.Add (current.left);
            if (current.right == null)
            {
                current.right = new BinaryTree (values [i]);
                break;
            }
            queue.Add (current.right);
        }
        insert (values, i + 1);
    }
}
// Define other methods, classes and namespaces here
