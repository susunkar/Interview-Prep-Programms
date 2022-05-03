<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	TreeNode root = new TreeNode(5);
	
	root.left = new TreeNode(4,
								new TreeNode(11,
											new TreeNode(7),
											new TreeNode(2)), null);

	root.right = new TreeNode(8,
								new TreeNode(13),
								new TreeNode(4,
												null,
											new TreeNode(1)));
											
	root.Dump();	
	
	//TreeleafSum(root,0,22).Dump();
	Solution_V3 s = new Solution_V3();
	
	s.HasPathSum(root,22).Dump();
	
	
}
public class TreeNode{
	public int val;
	public TreeNode left;
	public TreeNode right;
	
	public TreeNode(int val=0, TreeNode left = null, TreeNode right = null){
		this.val = val;
		this.left = left;
		this.right = right;
	}
}


public bool TreeleafSum(TreeNode root, int sum, int targetSum){
	
	if(root == null)
		return false;

	if (root.left == null && root.right == null)
	{
		sum = sum + root.val;
		sum.Dump("sum");
		
		if (sum == targetSum)
			return true;
		else return false;
	}
	
	if(root.left != null)
	{
		var r = TreeleafSum(root.left, sum + root.val,targetSum);
		
		if (r == true) return true;
	}
	if(root.right !=null){
		var r = TreeleafSum(root.right, sum + root.val,targetSum);
		if (r == true) return true;
	}
	return false;
}

public class Solution_V1
{
	bool found = false;

	public bool HasPathSum(TreeNode root, int sum)
	{
		if (root == null)
		{
			return false;
		}

		Search(root, root.val, sum);

		return found;
	}

	private void Search(TreeNode root, int sum, int target)
	{
		if (found)
		{
			return;
		}

		if (root.left == null && root.right == null)
		{
			if (sum == target)
			{
				found = true;
			}

			return;
		}

		if (root.left != null)
		{
			Search(root.left, sum + root.left.val, target);
		}

		if (root.right != null)
		{
			Search(root.right, sum + root.right.val, target);
		}
	}

}

public class Solution_V2
{
	public bool Result = false;
	public bool HasPathSum(TreeNode root, int sum)
	{
		if (root == null)
			return false;

		DFS(root, sum);
		return Result;
	}

	public void DFS(TreeNode root, int target)
	{
		if (root.left == null && root.right == null)
		{
			if (target == root.val)
			{
				Result = true;
			}
			return ;
		}

		if (root.left != null && !Result)
		{
			DFS(root.left, target - root.val);
		}

		if (root.right != null && !Result)
		{
			DFS(root.right, target - root.val);
		}
	}
}

public class Solution_V3
{
	public bool HasPathSum(TreeNode root, int sum)
	{
		return pathSum(root, sum, 0);
	}

	bool pathSum(TreeNode node, int sum, int runningSum)
	{

		if (node == null)
		{
			return false;
		}

		runningSum += node.val;

		if (node.left == null && node.right == null)
		{
			return (runningSum == sum);
		}

		return pathSum(node.right, sum, runningSum) || pathSum(node.left, sum, runningSum);
	}
}