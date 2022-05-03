<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	BinaryTree bt = new BinaryTree();

	int[] nodes = new int[] {7,3,9,10,2,6,8,1}; 
	int[] nodes1 = new int[] {1,2,3,4,5,6,7,8}; 
	int[] nodes2 = new int[] {7,5,10,2,6,8,12,1,3}; 
	foreach (var element in nodes)
	{
		bt.add(element);
	}
	var r = bt.Contains(6);
	
	bt.Delete(1);
	r = bt.Contains(1);
	r.Dump();
}

public class BinaryNode
{
	public int? value;
	public BinaryNode left =null;
	public BinaryNode right =null;
	
	public BinaryNode(int val){
		value = val;
		left=null;
		right =null;
	}
	public void AddNodeToTree(int val)
	{
		if(value > val){
			if(left != null)
				left.AddNodeToTree(val);
			else
			{
				var temp = new BinaryNode(val);
				this.left = temp;
			}
		}
		else{
			if(right != null)
				right.AddNodeToTree(val);
			else{
				var temp = new BinaryNode(val);
				this.right = temp;
			}
		}
	}


	public BinaryNode RemoveNodeToTree()
	{
		if(left == null && right == null)
			return null;
		if(left == null)
			return right;
		if(right == null)
			return left;
		
		var child = left;
		var grandChild = child.right;
		
		if(grandChild != null){
			while(grandChild.right !=null){
				child = grandChild;
				grandChild= child.right;
			}
			value = grandChild.value;
			child.right = grandChild.left;
		}
		else{
			left = child.left;
			value = child.value;
		}
		return this;
	}
}

public class BinaryTree
{
	BinaryNode root;

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

	public void Delete(int value)
	{
		if (root.value == value)
			root = null;
		else
		{
			root.RemoveNodeToTree();
		}
	}

}


// Define other methods and classes here