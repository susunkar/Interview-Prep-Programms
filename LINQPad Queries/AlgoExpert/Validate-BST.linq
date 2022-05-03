<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Validate BST
    ///  O(n) | O(d) space
    /// </summary>
	var root = new BST (10);
    root.left = new BST (5);
    root.left.left = new BST (2);
    root.left.left.left = new BST (1);
    root.left.right = new BST (5);
    root.right = new BST (15);
    root.right.left = new BST (13);
    root.right.left.right = new BST (14);
    root.right.right = new BST (22);
    
    ValidateBst(root).Dump();
}
public static bool ValidateBst (BST tree)
{
    return ValidateBST (tree, Int32.MinValue, Int32.MaxValue);
}
public static bool ValidateBST (BST tree, int minValue, int maxValue)
{
    if(tree == null)
        return true;
        
    if (tree.value < minValue || tree.value >= maxValue)
    {
        return false;
    }
    var leftIsValid = ValidateBST (tree.left, minValue, tree.value);
    var rightIsValid = ValidateBST (tree.right, tree.value, maxValue);
    return leftIsValid && rightIsValid;
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
