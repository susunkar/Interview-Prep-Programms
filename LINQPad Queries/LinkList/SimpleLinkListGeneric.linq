<Query Kind="Program" />

void Main()
{
	node<string> HeadNode = new node<string>("A");
	node<string> n1 = new node<string>("B");
	node<string> n2 = new node<string>("C");
	
	HeadNode.SetNextNode(n1);
	n1.SetNextNode(n2);
	n1.SetParentNode(HeadNode);
	
	n2.SetParentNode(n1);
	
	LinkList<string> temp = new LinkList<string>();
	temp.Head = HeadNode;
	node<string> n3 = new node<string>("D");
	
	temp.AddCellBefore(n3);
	temp.Display();
}
public class LinkList<T>{
	public node<T> Head;

	public void Display()
	{
		var temp = Head;
		while (temp != null)
		{
			temp.GetData().Dump();
			temp = temp.GetNextNode();
		}
	}
	public void AddCellBefore(node<T> new_cell)
	{
		var temp = Head;
		new_cell.SetNextNode(temp);
		temp.SetParentNode(new_cell);
		Head = new_cell;
	}
	public void AddCellInMiddle(node<T> lnk, node<T> new_cell)
{

}
	public void DeleteCellInMiddel(node<T> lnk)
{
}
	public void DeleteCellInBeganing(node<T> lnk)
{
}
}
public class node<T>{
	private T _data;
	private node<T> _next;
	private node<T> _parent;
	
	public node(T data){
		this._data = data;
		SetNextNode(null);
	}
	public void SetNextNode(node<T> nxtNode){
		this._next = nxtNode;
	}
	public T GetData(){
		return _data;
	}
	public node<T> GetNextNode(){
		return _next;
	}
	public node<T> GetParentNode()
	{
		return _parent;
	}
	public void SetParentNode(node<T> parent){
		this._parent = parent;
	}
}
// Define other methods and classes here
