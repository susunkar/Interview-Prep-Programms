<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Flatten Binary tree
    ///             1
    ///     2               3
    /// 4       5        6
    ///       7   8    
    /// output: Like linked List
    /// 4<-> 2 <-> 7 <-> 5 <-> 8 <-> 1 <-> 6 <-> 3
    /// </summary>
    BinaryTree root = new BinaryTree (1);
    insert (root, new int[] { 2, 3, 4, 5, 6 });
    root.left.right.left = new BinaryTree (7);
    root.left.right.right = new BinaryTree (8);
    
    BinaryTree leftMostNode = FlattenBinaryTree (root);
    List<int> leftToRightToLeft = this.leftToRightToLeft (leftMostNode);
    
    List<int> expected = new List<int>(){ 4, 2, 7, 5, 8, 1, 6, 3, 3, 6, 1, 8, 5, 7, 2, 4 };
    Xunit.Assert.True (expected.SequenceEqual (leftToRightToLeft),"pass".Dump());
}
public static BinaryTree FlattenBinaryTree (BinaryTree root)
{
    List<BinaryTree> inOrderNodes = getNodesInOrder (root, new List<BinaryTree>());
    for (int i = 0; i < inOrderNodes.Count - 1; i++)
    {
        BinaryTree leftNode = inOrderNodes [i];
        BinaryTree rightNode = inOrderNodes [i + 1];
        leftNode.right = rightNode;
        rightNode.left = leftNode;
    }
    return inOrderNodes [0];
}

public static List<BinaryTree> getNodesInOrder (BinaryTree tree, List<BinaryTree> array)
{
    if (tree != null)
    {
        getNodesInOrder (tree.left, array);
        array.Add (tree);
        getNodesInOrder (tree.right, array);
    }
    return array;
}
// This is the class of the input root. Do not edit it.
public class BinaryTree
{
    public int value;
    public BinaryTree left = null;
    public BinaryTree right = null;

    public BinaryTree (int value)
    {
        this.value = value;
    }
}








//======================= Testing ============================
public void insert (BinaryTree root, int[] values)
{
    insert (root, values, 0);
}

public void insert (BinaryTree root, int[] values, int i)
{
    if (i >= values.Length)
    {
        return;
    }
    Queue<BinaryTree> queue = new Queue<BinaryTree>();
    queue.Enqueue (root);
    while (queue.Count > 0)
    {
        BinaryTree current = queue.Dequeue();
        if (current.left == null)
        {
            current.left = new BinaryTree (values [i]);
            break;
        }
        queue.Enqueue (current.left);
        if (current.right == null)
        {
            current.right = new BinaryTree (values [i]);
            break;
        }
        queue.Enqueue (current.right);
    }
    insert (root, values, i + 1);
}

public List<int> leftToRightToLeft (BinaryTree leftMost)
{
    List<int> nodes = new List<int>();
    BinaryTree current = leftMost;
    while (current.right != null)
    {
        nodes.Add (current.value);
        current = current.right;
    }
    nodes.Add (current.value);
    while (current != null)
    {
        nodes.Add (current.value);
        current = current.left;
    }
    return nodes;
}
// Define other methods, classes and namespaces here
