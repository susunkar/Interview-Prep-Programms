<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	/// <summary>
	/// ReverseLinkedList
	/// </summary>
}
public static LinkedList ReverseLinkedList(LinkedList head){
	LinkedList p1 = null;
	LinkedList p2 = head;
	
	while(p2 != null){
		LinkedList p3 = p2.next;
		p2.next = p1;
		p1 = p2;
		p2 = p3;
	}
	return p1;
	
}
public class LinkedList{
	public int value;
	public LinkedList next;
	
	public LinkedList(int value){
		this.value = value;
		this.next = null;
	}
}

// Define other methods, classes and namespaces here
