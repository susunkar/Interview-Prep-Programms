<Query Kind="Program" />

class ListNode
{
	public char val;
	public ListNode next;
	public ListNode(char x) { val = x; }
}

void Main()
{
	ListNode a = new ListNode('a');
	ListNode b = new ListNode('b');
	ListNode c = new ListNode('c');
	ListNode d = new ListNode('d');
	ListNode e = new ListNode('e');
	ListNode f = new ListNode('f');

	a.next = b;
	b.next = c;
	c.next = d;
	d.next = e;
	e.next = f;
	f.next = null;
	
	a.Dump();
	ReverseLinkList(a).Dump();
	ListNode ReverseLinkList(ListNode head)
	{
		if (head == null) return null;
		ListNode current = head;
		ListNode previous = null;

		while (current != null)
		{
			ListNode NextNode = current.next;
			current.next = previous;
			previous = current;
			current = NextNode;
		}
		return previous;
	}
	
	PrintLinkListReverseOrder(a);
	//Recursive Code
	void PrintLinkListReverseOrder(ListNode node){
		if(node == null) return;

		PrintLinkListReverseOrder(node.next);
		Console.Write($"{node.val}->");
	}
}

// You can define other methods, fields, classes and namespaces here