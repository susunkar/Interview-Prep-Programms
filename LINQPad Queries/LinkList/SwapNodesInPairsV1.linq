<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4,null))));
    //head.Dump();
    
    ListNode r = SwapPairs(head);
    r.Dump();
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode (int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public ListNode SwapPairs (ListNode head)
{
    if (head == null || head.next == null)
        return head;
        
    ListNode curr = head.next.next;
    ListNode prev = head;
    head = head.next;
    head.next = prev;

    // Fix remaining nodes  
    while (curr != null && curr.next != null)
    {
        prev.next = curr.next;
        prev = curr;
        ListNode next = curr.next.next;
        curr.next.next = curr;
        curr = next;
    }

    prev.next = curr;
    return head;
}
// You can define other methods, fields, classes and namespaces here
