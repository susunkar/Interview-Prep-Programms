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
	
	DeprthFiestValueReq(a).Dump();
	//OutPut: abdecf
	
}
public string DeprthFiestValueReq(Node root){
	if(root == null) return string.Empty;
		
	string v1 = DeprthFiestValueReq(root.left);
	string v2 = DeprthFiestValueReq(root.right);
	return root.val.ToString() + v1 + v2;
}
public string DepthFirstValue(Node root){
	if(root == null) return string.Empty;
	
	Stack<Node> st = new Stack<UserQuery.Node>();
	StringBuilder dfsValue = new StringBuilder();
	st.Push(root);
	
	while(st.Count >0 ){
		Node temp = st.Pop();
		dfsValue.Append(temp.val);
		
		if(temp.right != null){
			st.Push(temp.right);
		}
		if (temp.left != null)
		{
			st.Push(temp.left);
		}
	}
	return dfsValue.ToString();
}
public class Node {
	public char val;
	public Node left;
	public Node right;
	public Node(char val){
		this.val= val;
		this.left = null;
		this.right = null;
	}
}
// You can define other methods, fields, classes and namespaces here