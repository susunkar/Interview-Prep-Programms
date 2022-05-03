/*
 * @lc app=leetcode id=82 lang=csharp
 *
 * [82] Remove Duplicates from Sorted List II
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
    public ListNode DeleteDuplicates(ListNode head) {
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
                fast= slow.next;
            }
            else{
                slow = slow.next;
                fast = fast.next;
            }
        }
	return dummy.next;
    }
}
// @lc code=end

