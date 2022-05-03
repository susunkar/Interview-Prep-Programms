<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	TreeNode root = new TreeNode(1);
	root.left = new TreeNode(2,new TreeNode(3),new TreeNode(4));
	root.right = new TreeNode(2,new TreeNode(4), new TreeNode(3));
	
	root.Dump();
	IsSymmetric(root).Dump();
	
}
public class TreeNode
{
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
		this.right = right;
     }
 }
 
public bool IsSymmetric(TreeNode root){

	return SymatricTree(root, root);
}
public bool SymatricTree(TreeNode l, TreeNode r)
{
	if (l == null && r == null)
	{
		return true;
	}
	else if (l != null && r != null)
	{
		if (l.val == r.val)
		{
			return SymatricTree(l.left, r.right) && SymatricTree(l.right, r.left);
		}
		else return false;
	}
	else return false;
}

// Define other methods, classes and namespaces here
