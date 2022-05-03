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
//	var r = bt.Contains(13);
//	r.Dump();

	BinaryNode temp = bt.root;
	
	bt.hasPathSum(temp, 27).Dump();
	
	BinaryNode temp1 = bt.root;
	List<int> pathList = new List<int>();
	bt.PrintPath(temp1,pathList);
	
	BinaryNode temp2 = bt.root;
	
	var commAC = bt.LeastCommonAncestor(temp2, 4, 13);
	commAC.Dump();
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

	public bool hasPathSum(BinaryNode node, int sum)
	{
		if(node.left == null && node.right == null){
			node.value.Dump();
			sum.Dump(); 
			return sum == node.value;
		}
		int subSum = sum - (int)node.value;
		
		if(node.left != null){
			node.value.Dump();
			bool hasPathSumCheck = hasPathSum(node.left, subSum);
			if(hasPathSumCheck) return true;
		}
		if (node.right != null)
		{
			node.value.Dump();
			bool hasPathSumCheck = hasPathSum(node.right, subSum);
			if(hasPathSumCheck) return true;
		}
		return false;
	}
	
	public void PrintPath(BinaryNode node, List<int> pathList)
	{
		if(node == null)
			return;
		pathList.Add((int)node.value);

		PrintPath(node.left, pathList);
		PrintPath(node.right, pathList);

		if (node.left == null && node.right == null)
		{
			pathList.Dump();
			pathList.Sum().Dump();
		}
		if (node.left != null && node.right == null)
		{
			pathList.Dump();
			pathList.Sum().Dump();
		}
		pathList.Remove((int)node.value);
	}
	
	public BinaryNode LeastCommonAncestor(BinaryNode node, int a, int b){
		
		if(node == null)
			return null;
		
		if(node.value == a || node.value == b)
			return node;
		var LeftCA = 	LeastCommonAncestor (node.left, a,b);
		var RighCA = 	LeastCommonAncestor (node.right, a,b);
		
		if(LeftCA !=null && RighCA !=null)
		{
				return node;
		}
		if(LeftCA !=null){
			return LeftCA;
		}
		return RighCA;
	}
}


// Define other methods and classes here