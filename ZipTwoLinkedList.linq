<Query Kind="Program" />


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

	ListNode q = new ListNode('q');
	ListNode r = new ListNode('r');

	q.next = r;

	ZipTwoLinkedList(a, q).Dump();
	ListNode ZipTwoLinkedList(ListNode head1, ListNode head2)
	{
		ListNode current1 = head1.next;
		ListNode current2 = head2;
		ListNode tail = head1; 	
		int count = 0;

		while (current1 != null && current2 != null)
		{
			if (count % 2 == 0)
			{
				tail.next = current2;
				current2 = current2.next;
			}
			else
			{
				tail.next = current1;
				current1 = current1.next;
			}
			tail = tail.next;
		}
		if(current1 != null) {
			tail.next = current1;
		}
		if (current2 != null)
		{
			tail.next = current2;
		}
		return head1;
	}
}
class ListNode
{
	public char val;
	public ListNode next;
	public ListNode(char x) { val = x; }
}

// You can define other methods, fields, classes and namespaces here

// You can define other methods, fields, classes and namespaces here