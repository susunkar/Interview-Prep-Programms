<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// BST Traversel
    /// </summary>
    var root = new BST (10);
    root.left = new BST (5);
    root.left.left = new BST (2);
    root.left.left.left = new BST (1);
    root.left.right = new BST (5);
    root.right = new BST (15);
    root.right.right = new BST (22);

    List<int> inOrder = new List<int> {
            1, 2, 5, 5, 10, 15, 22
        };
    List<int> preOrder = new List<int> {
            10, 5, 2, 1, 5, 15, 22
        };
    List<int> postOrder = new List<int> {
            1, 2, 5, 5, 22, 15, 10
        };

    Xunit.Assert.True (Enumerable.SequenceEqual (InOrderTraverse (root, new List<int>()), inOrder),"Pass".Dump());
    Xunit.Assert.True (Enumerable.SequenceEqual (PreOrderTraverse (root, new List<int>()), preOrder),"Pass".Dump());
    Xunit.Assert.True (Enumerable.SequenceEqual (PostOrderTraverse (root, new List<int>()), postOrder),"Pass".Dump());
}
public static List<int> InOrderTraverse (BST tree, List<int> array)
{
    if (tree.left != null)
    {
        InOrderTraverse (tree.left, array);
    }
    array.Add (tree.value);
    if (tree.right != null)
    {
        InOrderTraverse (tree.right, array);
    }
    return array;
}

public static List<int> PreOrderTraverse (BST tree, List<int> array)
{
    array.Add (tree.value);
    if (tree.left != null)
    {
        PreOrderTraverse (tree.left, array);
    }
    if (tree.right != null)
    {
        PreOrderTraverse (tree.right, array);
    }
    return array;
}

public static List<int> PostOrderTraverse (BST tree, List<int> array)
{

    if (tree.left != null)
    {
        PostOrderTraverse (tree.left, array);
    }
    if (tree.right != null)
    {
        PostOrderTraverse (tree.right, array);
    }
    array.Add (tree.value);
    return array;
}

public class BST
{
    public int value;
    public BST left;
    public BST right;

    public BST (int value)
    {
        this.value = value;
    }
}

// Define other methods, classes and namespaces here
