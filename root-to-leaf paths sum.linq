<Query Kind="Program" />

public class Node
{
	public int val;
	public Node left;
	public Node right;
	public Node(int val)
	{
		this.val = val;
		this.left = null;
		this.right = null;
	}
}
void Main()
{

	Node a = new Node(5);
	Node b = new Node(4);
	Node c = new Node(8);
	Node d = new Node(9);
	Node e = new Node(13);
	Node f = new Node(4);
	Node g = new Node(7);
	Node h = new Node(2);
	Node i = new Node(3);
	Node j = new Node(1);

	a.left = b;
	a.right = c;

	b.right = d;

	c.left = e;
	c.right = f;

	d.left = g;
	d.right = h;

	f.left = i;
	f.right = j;

	//a.Dump();
	
	List<int> path = new List<int>();
	int level = 0 ;
	InOrderTravel(a,path, level);
	
	maxDepthvalue(a,0).Dump();

	void InOrderTravel(Node root,List<int> path,int level){
		if(root == null) return;
		
		path.Insert(level, root.val);
		level++;

		if (root.left == null && root.right == null)
		{
			int sum = 0;
			for (int i = 0; i < level; i++)
			{
				Console.Write($"{path[i]} -> ");
				sum += path[i];
			}
			Console.WriteLine($"{sum}");
		}
		else
		{
			InOrderTravel(root.right, path, level);
			InOrderTravel(root.left, path, level);
		}
	}

	int maxDepthvalue(Node root, int level)
	{
		if (root == null) return level;
		level+=root.val;
		return Math.Max(maxDepthvalue(root.left, level), maxDepthvalue(root.right, level));
	}

}

// You can define other methods, fields, classes and namespaces here