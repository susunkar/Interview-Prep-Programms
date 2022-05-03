/*
 * @lc app=leetcode id=86 lang=csharp
 *
 * [86] Partition List
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
    public ListNode Partition(ListNode head, int x) {
        ListNode dummy1 = new ListNode();
        ListNode dummy2 = new ListNode();

        ListNode current1 = dummy1;
        ListNode current2 = dummy2;

        while(head!=null) {
            if(head.val <x){
                current1.next = head;
                current1 = head;
            }
            else{
                current2.next = head;
                current2 = head;
            }
            head = head.next;
        }
        current2.next = null;
        current1.next = dummy2.next;
        return dummy1.next;
    }

}
// @lc code=end

