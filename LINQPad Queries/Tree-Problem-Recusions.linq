<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Node<string > root = new UserQuery.Node<string>("A");
	
	Node<string>  b = new Node<string> ("B");
	
	Node<string>  d = new Node<string> ("D");
	d.setLeftChild(new Node<string> ("F"));
	d.setRightChild(new Node<string> ("H"));

	Node<string> e = new Node<string>("E");
	e.setRightChild(new Node<string>("G"));

	Node<string> c = new Node<string>("C");
	c.setLeftChild(d);
	c.setRightChild(e);


	root.setLeftChild(b);
	root.setRightChild(c);
	
	root.Dump();
	
	mirror(root);
	
	root.Dump();
}

void mirror(Node<string> root)
{
	if(root == null)
		return;

	mirror(root.getLeftChild());
	mirror(root.getRightChild());

	Node<string> temp = new Node<string>();
	temp = root.getLeftChild();
	root.setLeftChild(root.getRightChild());
	root.setRightChild(temp);
}

public class Node<T>
{
	private T data;
	private Node<T> leftChild;
	private Node<T> rightChild;

	public Node()
	{
	}

	public Node(T data)
	{
		this.data = data;
	}

	public T getData()
	{
		return data;
	}
	public Node<T> getLeftChild()
	{
		return leftChild;
	}
	
	public Node<T> getRightChild(){
		return rightChild;
	}
	
	public void setLeftChild(Node<T> leftChild){
		this.leftChild = leftChild;
	}
	
	public void setRightChild(Node<T> rightChild)
	{
		this.rightChild= rightChild;
	}

}


// Define other methods, classes and namespaces here