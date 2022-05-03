<Query Kind="Program" />

void Main()
{
	Node LinkList = new Node(1, new Node(2, 
	new Node(3, new Node(4, new Node(5,new Node(6, new Node(7,new Node(8, 
	new Node(9)))))))));
	LinkList.Dump();
	
	Node midNode = GetMiddleNode(LinkList);
	midNode.Dump();
	
}

Node GetMiddleNode(Node linkList)
{
	Node head = linkList;
	
	if(linkList == null || linkList.nextNode ==null){
		return linkList;
	}
	
	Node slow = head;
	Node fast = head;
	Node mid = head;
	while(fast != null && fast.nextNode !=null){
		mid = slow;
		slow = slow.nextNode;
		fast = fast.nextNode.nextNode;
	}
	return mid;
}

public class Node{
	public int value;
	public Node nextNode;
	
	public Node(int val, Node next=null){
		this.value = val;
		this.nextNode = next;
	}
}
// You can define other methods, fields, classes and namespaces here