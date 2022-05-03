<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Iterative In-Order Traversal (no recurs call stack)
    /// 
    /// </summary>

    var root = new BinaryTree (1);
    root.left = new BinaryTree (2, root);
    root.left.left = new BinaryTree (4, root.left);
    root.left.left.right = new BinaryTree (9, root.left.left);
    root.right = new BinaryTree (3, root);
    root.right.left = new BinaryTree (6, root.right);
    root.right.right = new BinaryTree (7, root.right);


    ProgramTest test = new ProgramTest();
    test.testArray.Clear();
    IterativeInOrderTraversal (root, test.testCallback);
    Enumerable.SequenceEqual (test.testArray, new List<int> {4, 9, 2, 1, 6, 3, 7 }).Dump();

}
//O(n) time | O(1) space
public static void IterativeInOrderTraversal (BinaryTree tree, Action<BinaryTree> callback)
{
    BinaryTree previousNode = null;
    BinaryTree currentNode = tree;
    while (currentNode != null)
    {
        BinaryTree nextNode;
        if (previousNode == null || previousNode == currentNode.parent)
        {
            if (currentNode.left != null)
            {
                nextNode = currentNode.left;
            }
            else
            {
                callback (currentNode);
                nextNode = currentNode.right != null ? currentNode.right : currentNode.parent;
            }
        }
        else
        {
            if (previousNode == currentNode.left)
            {
                callback (currentNode);
                nextNode = currentNode.right != null ? currentNode.right : currentNode.parent;
            }
            else
            {
                nextNode = currentNode.parent;
            }
        }
        previousNode = currentNode;
        currentNode = nextNode;
    }
}

public class BinaryTree
{
    public int value;
    public BinaryTree left;
    public BinaryTree right;
    public BinaryTree parent;

    public BinaryTree (int value)
    {
        this.value = value;
    }

    public BinaryTree (int value, BinaryTree parent)
    {
        this.value = value;
        this.parent = parent;
    }
}
public class ProgramTest
{
    public List<int> testArray = new List<int>();

    public void testCallback (BinaryTree tree)
    {
        if (tree == null)
        {
            return;
        }
        testArray.Add (tree.value);
        return;
    }
}
// Define other methods, classes and namespaces here
