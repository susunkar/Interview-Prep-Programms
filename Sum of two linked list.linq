<Query Kind="Program" />

void Main()
{
	ListNode a = new ListNode(2, new ListNode(4, new ListNode(3)));
	ListNode b = new ListNode(5, new ListNode(6, new ListNode(4)));
	AddTwoNumbers(a,b).Dump("Result");
	
}
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
public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
	ListNode dummy = new ListNode();
	ListNode temp = dummy;
	int sum = 0;
	while (l1 != null || l2 != null)
	{
		if (l1 != null)
		{
			sum = (l1.val + sum);
			l1 = l1.next;
		}
		if (l2 != null)
		{
			sum = (l2.val + sum);
			l2 = l2.next;
		}
		temp.next = new ListNode(sum % 10);
		sum = sum / 10;
		temp = temp.next;
	}
	if (sum > 0)
	{
		temp.next = new ListNode(sum);
		temp = temp.next;
	}
	ListNode result = ReversLinkedList(dummy.next);
	return result;
}
public ListNode ReversLinkedList(ListNode head){
	ListNode prev = null;
	while(head!=null){
		ListNode temp = head.next;
		head.next = prev;
		prev = head;
		head = temp;
	}
	return prev;
}
// You can define other methods, fields, classes and namespaces here