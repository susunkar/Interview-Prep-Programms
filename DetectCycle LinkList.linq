<Query Kind="Program" />

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}
public ListNode DetectCycle(ListNode head)
{
	ListNode fast = head;
	ListNode dummy = new ListNode();
	ListNode slow = dummy;
	
	slow.next = fast;
	
	while(fast!= null){
		while(fast.next!=null && fast.val == fast.next.val){
			fast = fast.next;
		}
		if(slow.next != fast){
			slow.next =fast.next;
		}
		else{
			slow = slow.next;
			fast = fast.next;
		}
	}
	return dummy.next;
}
void Main()
{

	


}

// You can define other methods, fields, classes and namespaces here