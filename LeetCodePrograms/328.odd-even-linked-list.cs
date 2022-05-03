/*
 * @lc app=leetcode id=328 lang=csharp
 *
 * [328] Odd Even Linked List
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
    public ListNode OddEvenList(ListNode head) {
        if(head == null) return null;
        if(head.next == null) return head;
        if(head.next.next == null) return head;

        
        ListNode evenHead = head.next;
        ListNode currentOddHead = head;
        ListNode currentEvenHead = head.next;

        while(currentEvenHead != null && currentEvenHead.next !=null  ){
            currentOddHead.next = currentEvenHead.next;
            currentOddHead = currentEvenHead.next;
            currentEvenHead.next = currentOddHead.next;
            currentEvenHead = currentEvenHead.next;
        }
        currentOddHead.next = evenHead;
        return head;
    }
}
// @lc code=end

