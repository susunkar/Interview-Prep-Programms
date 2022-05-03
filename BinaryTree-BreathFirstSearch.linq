<Query Kind="Program" />

void Main()
{
	Node a = new Node('a');
	Node b = new Node('b');
	Node c = new Node('c');
	Node d = new Node('d');
	Node e = new Node('e');
	Node f = new Node('f');

	a.left = b;
	a.right = c;
	b.left = d;
	b.right = e;
	c.right = f;

	BreadthFirstValues(a).Dump();
}

public string BreadthFirstValues(Node root)
{
	if (root == null) return string.Empty;

	Queue<Node> qu = new Queue<UserQuery.Node>();
	StringBuilder dfsValue = new StringBuilder();
	qu.Enqueue(root);

	while (qu.Count > 0)
	{
		Node temp = qu.Dequeue();
		dfsValue.Append(temp.val);

		if (temp.left != null)
		{
			qu.Enqueue(temp.left);
		}
		if (temp.right != null)
		{
			qu.Enqueue(temp.right);
		}
		
	}
	return dfsValue.ToString();
}
public class Node
{
	public char val;
	public Node left;
	public Node right;
	public Node(char val)
	{
		this.val = val;
		this.left = null;
		this.right = null;
	}
}
// You can define other methods, fields, classes and namespaces here