/*
 * @lc app=leetcode id=160 lang=csharp
 *
 * [160] Intersection of Two Linked Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if(headA == null || headB == null) {
            return null;
        }
        var head1 = headA;
        var head2 = headB;
       
        while(head1 != null){
          
            while(head2 != null ){
                if(head1 == head2){
                    return head1;
                }
                if(head1.next == head2.next) {
                    return head1.next;
                }
                head2 = head2.next;
            }
            head2 = headB;
            head1 = head1.next;
        }
        return null;
    }
}
// @lc code=end

