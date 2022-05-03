<Query Kind="Program" />

/*
	Binary Tree
	1. at most 3 children per node
	2. exactly 1 root
	3. exactly 1 path b/w root and any node
*/
void Main()
{
	Node a = new Node ('a');
	Node b = new Node ('b');
	Node c = new Node ('c');
	Node d = new Node ('d');
	Node e = new Node ('e');
	Node f = new Node ('f');

	a.Left = b;
	a.Right = c;
	
	b.Left = d;
	b.Right = e;

	c.Right = f;
	
	a.Dump();
	
	//DFS(a);
	//DFSReq(a);
	//BFS(a);
	
	TreeInclude(a,'E').Dump();
}

public class Node {

	public char val;
	public Node Left;
	public Node Right;
	public Node (char val){
		this.val = val;
		this.Right = null;
		this.Left = null;
	}
}

public void DFS(Node root){
	if(root == null) return ;
	Stack<Node> nodestk = new Stack<Node>();
	nodestk.Push(root);
	Console.WriteLine("DFS");
	while(nodestk.Count>0){
		Node current = nodestk.Pop();
		if(current.Right != null){
			nodestk.Push(current.Right);
		}
		if(current.Left != null){
			nodestk.Push(current.Left);
		}
		Console.Write($" {current.val}");
	}
	
}
public void DFSReq(Node root){
	if(root == null) return;

	DFSReq(root.Left);
	DFSReq(root.Right);
	Console.Write($" {root.val}");
}

public void BFS(Node root){
	if (root == null) return;
	System.Collections.Generic.Queue<Node> que = new Queue<UserQuery.Node>();
	que.Enqueue(root);
	Console.WriteLine("\nBFS");
	while(que.Count>0){
		var node = que.Dequeue();
		Console.Write($" {node.val}");
		if(node.Left != null) que.Enqueue(node.Left);
		if(node.Right != null) que.Enqueue(node.Right);
	} 
}

public void BFSReq(Node root){
	if(root == null) return ;
	Queue<Node> que = new Queue<UserQuery.Node>();
	
	if (root.Left != null) que.Enqueue (root.Left);
	if (root.Right != null) que.Enqueue (root.Right);
}

public bool TreeInclude(Node root, char target){
	if(root == null) return false;
	if(root.val == target) return true;
	
	return TreeInclude(root.Left, target) || TreeInclude(root.Right, target);
}