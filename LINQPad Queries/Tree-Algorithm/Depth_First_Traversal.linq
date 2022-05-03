<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	BinaryTree bt = new BinaryTree();

	int[] nodes = new int[] { 5, 4, 9, 7, 13, 6, 8, 10 };

	foreach (var element in nodes)
	{
		bt.add(element);
	}
	var r = bt.Contains(13);
	r.Dump();
	
	
	var tnode = bt.root;
	"Pre-Order".Dump();
	bt.Depth_First_Traversal_PreOrderTraversal(tnode);
	
	var tnode1 = bt.root;
	"In-Order".Dump();
	bt.Depth_First_Traversal_InOrderTraversal(tnode1);

	var tnode2 = bt.root;
	"Post-Order".Dump();
	bt.Depth_First_Traversal_PostOrderTraversal(tnode1);


}

public class BinaryNode
{
	public int? value;
	public BinaryNode left = null;
	public BinaryNode right = null;

	public BinaryNode(int val)
	{
		value = val;
		left = null;
		right = null;
	}
	public void AddNodeToTree(int val)
	{
		if (value > val)
		{
			if (left != null)
				left.AddNodeToTree(val);
			else
			{
				var temp = new BinaryNode(val);
				this.left = temp;
			}
		}
		else
		{
			if (right != null)
				right.AddNodeToTree(val);
			else
			{
				var temp = new BinaryNode(val);
				this.right = temp;
			}
		}
	}
}

public class BinaryTree
{
	public BinaryNode root;

	public void add(int val)
	{
		if (root == null)
		{
			root = new BinaryNode(val);
		}
		else
		{
			root.AddNodeToTree(val);
		}
	}

	public bool Contains(int val)
	{
		"root".Dump();
		var temp = root;
		while (temp != null)
		{
			if (temp.value == val)
			{
				"Found".Dump(temp.value.ToString());
				return true;
			}
			else if (temp.value > val)
			{
				"left".Dump(temp.value.ToString());
				temp = temp.left;
			}
			else
			{
				"right".Dump(temp.value.ToString());
				temp = temp.right;
			}
		}
		return false;
	}

	public void Depth_First_Traversal_PreOrderTraversal(BinaryNode node)
	{
		// Depth-first traversal involves going right to the leaf og the binary tree before mobing up the tree
		// 3 different type DFT
		// 1. PRE-ORDER (process the first, before left and right (Process, left, right))
		// 2. In-Order (process IN between left and right (left, Process, Right))
		// 3. Post-Order(Process POST of left and right (left, Right , Process))
		if (node == null)
			return;

		//Process
		$"{node.value}".Dump();
		
		//Left
		Depth_First_Traversal_PreOrderTraversal(node.left);
		
		//Right
		Depth_First_Traversal_PreOrderTraversal(node.right);

	}
	public void Depth_First_Traversal_InOrderTraversal(BinaryNode node)
	{
		// Depth-first traversal involves going right to the leaf og the binary tree before mobing up the tree
		// 3 different type DFT
		// 1. PRE-ORDER (process the first, before left and right (Process, left, right))
		// 2. In-Order (process IN between left and right (left, Process, Right))
		// 3. Post-Order(Process POST of left and right (left, Right , Process))
		if (node == null)
			return;



		//Left
		Depth_First_Traversal_InOrderTraversal(node.left);
		
		//Process
		$"{node.value}".Dump();
		
		//Right
		Depth_First_Traversal_InOrderTraversal(node.right);

	}
	public void Depth_First_Traversal_PostOrderTraversal(BinaryNode node)
	{
		// Depth-first traversal involves going right to the leaf og the binary tree before mobing up the tree
		// 3 different type DFT
		// 1. PRE-ORDER (process the first, before left and right (Process, left, right))
		// 2. In-Order (process IN between left and right (left, Process, Right))
		// 3. Post-Order(Process POST of left and right (left, Right , Process))
		if (node == null)
			return;

		//Left
		Depth_First_Traversal_PostOrderTraversal(node.left);

		//Right
		Depth_First_Traversal_PostOrderTraversal(node.right);

		//Process
		$"{node.value}".Dump();

	}
}


// Define other methods and classes here