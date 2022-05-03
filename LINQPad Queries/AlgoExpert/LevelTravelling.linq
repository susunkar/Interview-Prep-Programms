<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

public class BinaryTree
{
	public int value;
	public BinaryTree left;
	public BinaryTree right;

	public BinaryTree(int value)
	{
		this.value = value;
		left = null;
		right = null;
	}
}
void Main()
{
	BinaryTree root = new BinaryTree(1);
	root.left = new BinaryTree(2);
	root.right = new BinaryTree(3);

	root.left.left = new BinaryTree(4);
	root.left.right = new BinaryTree(5);

	root.left.left.left = new BinaryTree(8);
	root.left.left.right = new BinaryTree(9);

	root.right.left = new BinaryTree(6);
	root.right.right = new BinaryTree(7);

	NodeDepths(root);

}

public static int NodeDepths(BinaryTree root)
{
	Queue<BinaryTree> q = new Queue<UserQuery.BinaryTree>();

	q.Enqueue(root);
	int level = 0;
	int sum =0;
	while (true)
	{
		int nodeClount = q.Count;
		if (nodeClount == 0)
			break;

		Console.Write($"level {level} : Node Count {nodeClount} : ");
		sum = sum + level * nodeClount;
		while (nodeClount > 0)
		{
			var n = q.Dequeue();
			nodeClount --;
			
			if (n.left != null)
			{
				q.Enqueue(n.left);

			}
			if (n.right != null)
			{
				q.Enqueue(n.right);

			}
			
			Console.Write($" node {n.value}");
		}
		level ++;
		Console.WriteLine();
	}

	sum.Dump();
	// Write your code here.
	return 1;
}

//Hight or Depth
public int MaxDepth(BinaryTree root)
{
	if (root == null)
		return 0;
	int leftHight = MaxDepth(root.left);
	int rightHight = MaxDepth(root.right);

	return Math.Max(leftHight, rightHight) + 1;
}

// Define other methods, classes and namespaces here