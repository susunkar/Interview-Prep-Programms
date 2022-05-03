/*
 * @lc app=leetcode id=19 lang=csharp
 *
 * [19] Remove Nth Node From End of List
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode current = head;
        int totalCount = 0;

        while(current != null){
            current = current.next;
            totalCount++;
        }
        if(totalCount == 1){
            return null;
        }
        
        current = head;
        ListNode prev= null;
        int i =0;
        while(i<(totalCount-n)){
            prev = current;
            current = current.next;
            i++;
        }
        if(prev == null){
            prev = current.next;    
            return prev;
        }
        else{
            prev.next = current.next;
        }

        current= head;
        while(head != null){
            if(head == prev){
                head= prev;
                break;
            }
            head = head.next;
        }
        return current;

    }
}
// @lc code=end

