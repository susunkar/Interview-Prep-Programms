<Query Kind="Program" />

void Main()
{
	node lnkLst = new node(10);
	lnkLst.GetData().Dump();
	lnkLst.GetNextNode().Dump();

	node n1 = new node(20);
	lnkLst.SetNextNode(n1);
	
	var headNode = lnkLst;
	
	while(headNode!=null){
		headNode.GetData().Dump();
		headNode = headNode.GetNextNode();
	}

}
public class node{
	private int _data;
	private node _next;
	
	public node(int data){
		this._data = data;
		SetNextNode(null);
	}
	public void SetNextNode(node nxtNode){
		this._next = nxtNode;
	}
	public int GetData(){
		return _data;
	}
	public node GetNextNode(){
		return _next;
	}
}
// Define other methods and classes here
