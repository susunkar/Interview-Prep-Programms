/*
 * @lc app=leetcode id=23 lang=csharp
 *
 * [23] Merge k Sorted Lists
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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists == null || lists.Length == 0) return null;
        PriorityQueue<Integer> priQueue = new PriorityQueue<>();
        
        for(int i=0; i<lists.Length ; i++){
            while(lists[i]!=null){
                priQueue.add(lists[i].val);
                lists[i] = lists[i].next;
            }
        }
        ListNode dummy = new ListNode(-1);
        ListNode head= dummy;
        
        while(!priQueue.isEmpty()){
            head.next= new ListNode(priQueue.remove());
            head = head.next;
        }
        
        return dummy.next;
    }
}
// @lc code=end

