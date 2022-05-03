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

}


// Define other methods and classes here