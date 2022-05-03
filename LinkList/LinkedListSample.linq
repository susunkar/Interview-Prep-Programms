<Query Kind="Program" />

void Main()
{
	var a = new Node ('A');
	var b = new Node ('B');
	var c = new Node ('C');
	var d = new Node ('D');
	
	a.next = b;
	b.next = c;
	c.next = d;
	
	//printLinkedList(a);
	//printLinedListREQ(a);
	//var result = reversLinkedList(a);
	//printLinkedList(result);


	var aa = new Node ('1');
	var ba = new Node ('2');
	var ca = new Node ('3');
	var da = new Node ('4');

	aa.next = ba;
	ba.next = ca;
	ca.next = da;
	var mer = ZipTwoLinkedList(a, aa);
	printLinkedList(mer);
}

public class Node{
	public Node next;
	public char value;
	
	public Node(char val){
		this.value= val;
		this.next = null;
	}
}

public void printLinkedList(Node head){
	UserQuery.Node current = head;
	
	while (current != null)
	{
		Console.WriteLine(current.value);
		current = current.next;
	}
}

public void printLinedListREQ(Node head){
	if(head == null) return;
	
	Console.WriteLine(head.value);
	
	printLinedListREQ(head.next);
}

public Node reversLinkedList(Node head){
	UserQuery.Node current = head;
	UserQuery.Node prev = null;
	
	while(current!=null){
	   var temp = current.next;
	   current.next = prev;
	   prev = current;
	   current = temp;
	}
	return prev;
}

public Node ZipTwoLinkedList(Node head1, Node head2){
	UserQuery.Node current1 = head1.next;
	UserQuery.Node current2 = head2;
	UserQuery.Node Zip = head1;
	
	int count = 0;
	while(current1!= null && current2 != null){
		if(count %2 ==0){
			Zip.next = current2;
			current2 = current2.next;
		}
		else
		{
			Zip.next = current1;
			current1 = current1.next;
		}
		count+=1;
		Zip = Zip.next;
	}
	
	if(current1!=null){
		Zip.next = current1;
	}
	if(current2 != null){
		Zip.next = current2;
	}
	return head1;
}