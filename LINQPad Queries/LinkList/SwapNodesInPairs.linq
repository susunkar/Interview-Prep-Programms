<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	List<ListNode> lnk = new List<UserQuery.ListNode>();
	lnk.Add(new ListNode(1,new ListNode(2,new ListNode(3,new ListNode(4,new ListNode(5)))))); 
	
	var r = SwapPairs(lnk[0]);
	
	r.Dump();
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
public static ListNode SwapPairs(ListNode head)
{
	if (head?.next == null)
	{
		return head;
	}

	ListNode dummyNode = new ListNode(0);
	dummyNode.next = head;

	ListNode ptr = dummyNode;
	while (ptr.next?.next != null)
	{
		var node1 = ptr.next;
		var node2 = ptr.next.next;
		var node3 = ptr.next.next.next;
		
		ptr.next = node2;
		node2.next = node1;
		node1.next = node3;
		
		ptr = node1;
	}

	return dummyNode.next;
}
	


// Define other methods, classes and namespaces here