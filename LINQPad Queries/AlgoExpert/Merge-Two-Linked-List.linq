<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	/// <summary>
	/// Merge Linked List
	/// two shorted Linked List is given
	/// 
	/// 2->6->7->8
	/// 1->3->4->5->9->10
	/// </summary>
}
public class LinkedList{
	public int value ;
	public LinkedList next;
	
	public LinkedList(int value){
		this.value = value;
		this.next = null;
	}
}
public static LinkedList mergeLinkedLists(LinkedList headOne, LinkedList headTwo){
	LinkedList p1 = headOne;
	LinkedList p1Prev = null;
	LinkedList p2 = headTwo;
	
	while(p1 != null && p2 !=null){
		if(p1.value < p2.value){
			p1Prev = p1;
			p1 = p1.next;
		}
		else{
			if(p1Prev != null){
				p1Prev.next = p2;
			}
			p1Prev = p2;
			p2 = p2.next;
			p1Prev.next = p1;
		}
		if(p1 == null){
			p1Prev.next = p2;
		}
	}
	return headOne.value < headTwo.value ? headOne : headTwo;
}

// Define other methods, classes and namespaces here
