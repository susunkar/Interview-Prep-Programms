<Query Kind="Program" />

void Main()
{
	Node a = new Node (1);
	Node b = new Node (2);
	Node c = new Node (3);
	Node d = new Node (4);
	Node e = new Node (5);
	Node f = new Node (6);
	Node g = new Node (7);
	Node h = new Node (8);
	Node i = new Node (9);

	a.Left = b;
	a.Right = c;
	b.Left = d;
	b.Right = e;
	
	c.Left = f;
	c.Right = g;
	
	e.Left = h;
	f.Right = i;
	a.Dump();
	//PathSum(a,0);
	//TreeSum(a).Dump();
	//MinNode(a).Dump();
	//MaxRootPath(a,0).Dump();
	SumOfLeafNodesAtMiniumLevel(a);
}

public class Node
{
	public int val;
	public Node Left;
	public Node Right;
	
	public Node (int val)
	{
		this.val = val;
		this.Right = null;
		this.Left = null;
	}
}

public int  PathSum(Node root, int pathSum){
	if(root == null) return 0;

	pathSum += root.val;
//	Console.WriteLine(pathSum);
	if (root.Left == null && root.Right == null)
	{
		Console.WriteLine(pathSum);
		return pathSum;
	}
	return PathSum(root.Left,pathSum) + PathSum(root.Right,pathSum);
	
}

public int TreeSum(Node root){
	if(root == null) return 0;

	return root.val+ TreeSum(root.Left) + TreeSum(root.Right);
}

public int MinNode(Node root){
	if(root == null) return  Int16.MaxValue;
	
	var LeftMin = MinNode(root.Left) ;
	var RightMin = MinNode(root.Right);
	
	var min = Math.Min(LeftMin,RightMin);
	return Math.Min(min,root.val);
}

public int MaxRootPath(Node root, int sum){
	if(root == null) return int.MinValue;
	
	sum += root.val;
	
	var mxLeft = MaxRootPath(root.Left, sum);
	var mxRight = MaxRootPath(root.Right, sum);
	var mx = Math.Max(mxLeft, mxRight);
	return Math.Max(sum, mx);
}

/*
Sum of leaf nodes at minimum level
Input : 
              1
            /   \
           2     3
         /  \   /  \
        4   5   6   7
           /     \
          8       9

Output : 11
Leaf nodes 4 and 7 are at minimum level.
Their sum = (4 + 7) = 11. 
*/

public void SumOfLeafNodesAtMiniumLevel(Node root){

	if(root == null) return;
	
	Queue<Node> nodeQue = new Queue<UserQuery.Node>();
	nodeQue.Enqueue(root);
	
	Dictionary<int, List<int>> levelNodeDic = new Dictionary<int, List<int>>();
	
	int level=0;
	while (true)
	{
		
		var NumberOfNodeInLevel = nodeQue.Count;
		List<int> LevelNodeValues = new List<int>();
		
		while (NumberOfNodeInLevel > 0)
		{
			var currentNode = nodeQue.Dequeue();

			if (currentNode.Left == null && currentNode.Right == null)
			{
				LevelNodeValues.Add (currentNode.val);
			}
			if (currentNode.Left != null)
			{
				nodeQue.Enqueue (currentNode.Left);
			}
			if (currentNode.Right != null)
			{
				nodeQue.Enqueue (currentNode.Right);
			}
			NumberOfNodeInLevel--;
		}
		//levelNodeDic.Add(level,LevelNodeValues);
		
		if(LevelNodeValues.Count==2){
			Console.WriteLine(LevelNodeValues[0] + LevelNodeValues[1]);
			break;
		}
		level++;
	}

	//levelNodeDic.Dump();
}