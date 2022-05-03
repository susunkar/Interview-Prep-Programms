<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	/// <summary>
	/// Rearrange Linked List
	/// Head = 3 -> 0 -> 5 -> 2 -> 1 -> 4
	/// k = 3
	/// out: 0 -> 2 -> 1 -> 3 -> 5 -> 4 
	/// 
	/// node value is less then k should be before k, and if possiblr maintain order of the node
	/// </summary>

	var head = new LinkedList(3);
	head.next = new LinkedList(0);
	head.next.next = new LinkedList(5);
	head.next.next.next = new LinkedList(2);
	head.next.next.next.next = new LinkedList(1);
	head.next.next.next.next.next = new LinkedList(4);
	var result = RearrangeLinkedList(head, 3);
	
	result.Dump();

}
public class LinkedList{
	public int value;
	public LinkedList next;
	
	public LinkedList(int value){
		this.value = value;
		next = null;
	}
}
public class LinkedListPair{
	public LinkedList head;
	public LinkedList tail;
	
	public LinkedListPair(LinkedList head, LinkedList tail){
		this.head = head;
		this.tail = tail;
	}
}
public static LinkedList RearrangeLinkedList (LinkedList head, int k){
	LinkedList smallListHead = null;
	LinkedList smallListTail = null;

	LinkedList equalListHead = null;
	LinkedList equalListTail = null;

	LinkedList greaterListHead = null;
	LinkedList greaterListTail = null;
	
	LinkedList node = head;
	while (node != null)
	{
		if(node.value < k){
			LinkedListPair smallerList = growLinkeList(smallListHead, smallListTail, node);
			smallListHead = smallerList.head;
			smallListTail = smallerList.tail; 
		}
		else {
			if (node.value == k)
			{
				LinkedListPair equalList = growLinkeList(equalListHead, equalListTail,node);
				equalListHead = equalList.head;
				equalListTail = equalList.tail;
			}
			else
			{
				LinkedListPair greaterList = growLinkeList(greaterListHead, greaterListTail,node);
				greaterListHead = greaterList.head;
				greaterListTail = greaterList.tail;
			}
		}
		LinkedList prevNode = node;
		node = node.next ;
		prevNode.next = null;
		
	}
	
	LinkedListPair firstPair = connectLinkedLists(smallListHead, smallListTail, equalListHead, equalListTail);
	LinkedListPair finalPair = connectLinkedLists(firstPair.head, firstPair.tail, greaterListHead, greaterListTail);
	
	return finalPair.head;

}

static LinkedListPair connectLinkedLists(LinkedList headOne, LinkedList tailOne, LinkedList headTwo, LinkedList tailTwo)
{
	LinkedList newHead = headOne == null? headTwo : headOne;
	LinkedList newTail = tailTwo == null? tailOne : tailTwo;
	
	if(tailOne != null) tailOne.next = headTwo;
	
	return new LinkedListPair(newHead, newTail);
}

private static LinkedListPair growLinkeList(LinkedList head, LinkedList tail, LinkedList node)
{
	LinkedList newHead = head;
	LinkedList newtail = node;
	
	if(newHead==null)	newHead = node;
	if(tail != null) tail.next = node;
	
	return new LinkedListPair(newHead, newtail );
}
// Define other methods, classes and namespaces here
