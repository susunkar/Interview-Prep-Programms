/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        ListNode fast = head;
		ListNode slow = head;
		
		while(fast !=null && fast.next != null){
			fast = fast.next.next;
			slow = slow.next;
		}
		if(fast!=null){
			slow = slow.next;
		}

		fast = head;
		slow = ReverLinkList(slow);
	
		while(slow!= null){
			if(slow.val != fast.val){
				return false;
			}
			slow = slow.next;
			fast = fast.next;
		}
		return true;
    }
    public ListNode ReverLinkList(ListNode head){
		ListNode previous = null;
		while (head != null)
		{
			ListNode temp = head.next;
			head.next = previous;
			previous = head;
			head = temp;
		}
		return previous;
	}
}
// @lc code=end

