<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	TreeNode r1 = new TreeNode(3,
								new TreeNode(9,null,null),
								new TreeNode(20,new TreeNode(15,null,null),new TreeNode(7,null,null))
								);

	TreeNode r = new TreeNode(1,
								new TreeNode(2, new TreeNode(4, null, null), null),
								new TreeNode(3, null, new TreeNode(5, null, null))
								);
	Solution s = new Solution();
	var result = s.LevelOrder(r);
	result.Dump();
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

public class Solution
{
	List<int> r = new List<int>();
	
	public List<int> PreorderTraversal(TreeNode root)
	{
		if (root != null)
		{
			r.Add((int)root.val);
			PreorderTraversal(root.left);
			PreorderTraversal(root.right);
		}
		return r;
	}
	public IList<int> InorderTraversal(TreeNode root)
	{
		List<int> answer = new List<int>();

		traversalHelper(root, answer);

		return answer;
	}

	private void traversalHelper(TreeNode node, List<int> result)
	{
		if (node != null)
		{
			traversalHelper(node.left, result);
			result.Add(node.val);
			traversalHelper(node.right, result);
		}
	}
	public IList<int> PostorderTraversal(TreeNode root)
	{
		var ans = new List<int>();
		var stack = new Stack<TreeNode>();
		stack.Push(root);
		while (stack.Count() > 0)
		{
			var curr = stack.Pop();
			if (curr == null) continue;
			ans.Insert(0, curr.val);
			stack.Push(curr.left);
			stack.Push(curr.right);

		}
		return ans;
	}

	
	public IList<IList<int>>  LevelOrder(TreeNode root)
	{
		IList<IList<int>> lnodes = new List<IList<int>>() ;
		levelTravel(root,lnodes);
		
		
		return lnodes;

	}
	private void levelTravel(TreeNode r, IList<IList<int>> narray)
	{
		Queue<TreeNode> q = new Queue<TreeNode>();
		q.Enqueue(r);

		while (true)
		{
			int counter = q.Count;
			var t = new List<int>();
			if (counter == 0)
			{
				break;
			}


			while (counter > 0)
			{
				
				var node = q.Dequeue();
				t.Add(node.val);
				
				if (node.left != null)
				{
					q.Enqueue(node.left);
				}
				if (node.right != null)
				{
					q.Enqueue(node.right);
				}
				counter --;
			}
			narray.Add(t);
		}
	}
}

// Define other methods, classes and namespaces here