<Query Kind="Program" />

void Main()
{
	Linklist lst = new Linklist();
	lst.Append(1);
	lst.Append(2);
	lst.Append(3);
	
	lst.Delete(2);
	lst.Delete(3);
	lst.Delete(10);
	lst.Append(4);
	
	lst.Reverse();
	lst.Delete(4);
	
	lst.Print();
}
public class Node {
	public int Value;
	public Node? Next;
	public Node (int val){
		this.Value = val;
		this.Next = null;
	}
}
public class Linklist {
	public Node? Head = null;
	
	public Linklist(){
		this.Head = null;
	}
	
	public void Append(int val){
		if(this.Head == null){
			this.Head = new Node(val);
		}
		else {
			Node current = Head;
			while(current.Next != null){
				current = current.Next;
			}
			current.Next = new Node(val);
		}
	}
	public void Print()
	{
		Node? current = Head;
		string str = string.Empty;
		while (current != null)
		{
			str += current.Value.ToString() + "->";
			current = current.Next;
		}
		str.Dump();
	}
	public void Delete(int val){
		Node? current = Head;
		Node? prev = null;
		
		if(Head.Value == val){
			Head = null;
		}
		while (current != null)
		{
			if (current.Value == val)
			{
				if (prev != null)
				{
					prev.Next = current.Next;
				}
			}
			prev = current;
			current = current.Next;
		}
	}
	public void Reverse(){
		Node? current = Head;
		Node? prev = null;
		
		if(Head==null){
			return;
		}
		
		while(current!=null){
			Node temp = current.Next;
			current.Next = prev;
			prev = current;
			current = temp;
		}
		Head = prev;
	}
}