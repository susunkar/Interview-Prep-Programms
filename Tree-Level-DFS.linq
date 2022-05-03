<Query Kind="Program" />

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
void Main()
{
	TreeNode a = new TreeNode(1);
	TreeNode b = new TreeNode(2);
	TreeNode c = new TreeNode(3);
	TreeNode d = new TreeNode(4);
	TreeNode e = new TreeNode(5);
	TreeNode f = new TreeNode(6);
	/*a.left = b;
	a.right = c;
	b.right= e;
	c.right = d;*/
	a.left = b;
	a.right= c;
	c.left = e;
	c.right = f;
	
	//a.Dump();
	LevelTreavel(a);
	
	void LevelTreavel(TreeNode root){
		Queue<TreeNode> q = new Queue<UserQuery.TreeNode>();
		
		q.Enqueue(root);
		int level =0;
		while(true){
			int count = q.Count();
			if(count == 0 ) break;
			level.Dump("Level");
			
			for(int i=0; i<count; i++){
				var p = q.Dequeue();
				p.val.Dump();
				
				if(p.left!=null){
					q.Enqueue(p.left);
				}
				if(p.right!=null){
					q.Enqueue(p.right);
				}
			}
			level++;
		}
	}

	IList<int> RightSideView(TreeNode root)
	{
		List<int> result = new List<int>();
		RightSideDFS(root, 1, result);
		return result;
	}

	void RightSideDFS(TreeNode node, int depth, List<int> result)
	{
		if (node == null)
			return;
		if (result.Count < depth)
			result.Add(node.val);
		RightSideDFS(node.right, depth + 1, result);
		RightSideDFS(node.left, depth + 1, result);
	}
}

// You can define other methods, fields, classes and namespaces here