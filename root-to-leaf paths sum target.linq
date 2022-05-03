<Query Kind="Program">
  <RuntimeVersion>6.0</RuntimeVersion>
</Query>

void Main()
{
	TreeNode root = new TreeNode(5);
	TreeNode b4 = new TreeNode(4);
	TreeNode c8 = new TreeNode(8);
	TreeNode d11= new TreeNode(11);
	TreeNode e13 = new TreeNode(13);
	TreeNode f4 = new TreeNode(4);
	TreeNode g7 = new TreeNode(7);
	TreeNode h2  = new TreeNode(2);
	TreeNode i5 = new TreeNode(5);
	TreeNode j1 = new TreeNode(1);
	
	root.left =b4; root.right = c8;
	b4.left = d11;
	c8.left = e13; c8.right =f4;
	d11.left =g7; d11.right= h2;
	f4.left = i5; f4.right = j1;
	
	PathSum(root,22).Dump();

}
List<IList<int>> pathSum = new List<IList<int>>();
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

public IList<IList<int>> PathSum(TreeNode root, int targetSum)
{
	List<int> leafPath = new List<int>();
	CalculatePathSum(root, leafPath, targetSum);

	return pathSum;
}

public void CalculatePathSum(TreeNode root, List<int> leafPath, int sum)
{
	if (root == null) return;

	leafPath.Add(root.val);

	if (root.left == null && root.right == null && sum-root.val == 0)
	{
		pathSum.Add(leafPath);
		return;
	}
	CalculatePathSum(root.left,new List<int>(leafPath), sum - root.val);
	CalculatePathSum(root.right,new List<int>(leafPath), sum - root.val);
}

// You can define other methods, fields, classes and namespaces here