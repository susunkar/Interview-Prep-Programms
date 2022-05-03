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
	
	"Minimum value".Dump();
	var mini = bt.root;
	bt.MinimumValue(mini);
	
	
	
	"Maximum Depth of tree".Dump();
	var temp= bt.root;
	var maxr = bt.MaximumDepthTree(temp);
	maxr.Dump();
	
	"Mirrir Binary Tree".Dump();
	var temp1 = bt.root;
	bt.MirrorBinaryTree(temp1);
	var mr= bt.Contains(13);
	temp1.Dump();
	
	
	"CountofTreeFormfromNNodes".Dump();
	int count = bt.CountTreeCanFormNnode(nodes.Length);
	count.Dump();
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
	
	public void MinimumValue(BinaryNode node)
	{
		if(node == null)
			return;
			
		if (node.left != null)
		{
			$"Minimum value {node.left.value}".Dump();
		}
		MinimumValue(node.left);
	}
	
	public int MaximumDepthTree(BinaryNode node){

		if (node == null)
		{
			return 0;
		}
		if(node.left == null && node.right == null){
			return 0;
		}

		 int MaxLeftDepth = 1 + MaximumDepthTree(node.left);
		 int MaxRightDepth = 1 + MaximumDepthTree(node.right);
		 
		return System.Math.Max(MaxLeftDepth,MaxRightDepth);
	}
	
	public void MirrorBinaryTree(BinaryNode node)
	{
		if(node == null)
		{
			return;
		}
		MirrorBinaryTree(node.left);
		MirrorBinaryTree(node.right);
		
		//Swap the nodes
		var temp = node.left;
		node.left = node.right;
		node.right = temp;
	}

	public int CountTreeCanFormNnode(int NumberofNodes)
	{
		/*
		t(n) = Sumition i= i to n [ t(i-1) * t(n -i)]
		https://www.geeksforgeeks.org/total-number-of-possible-binary-search-trees-with-n-keys/
		*/
		if(NumberofNodes <= 1)
		{
			return 1;
		}
		int sum = 0;
		for (int  i= 1;  i<= NumberofNodes; i++){
			int CountLeftTree= CountTreeCanFormNnode(i-1);
			int CountRightTree = CountTreeCanFormNnode(NumberofNodes -i);
		
			sum = sum+ (CountLeftTree * CountRightTree);
		}
		return sum;
	}
}


// Define other methods and classes here