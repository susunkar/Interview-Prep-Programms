/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        if(list1 == null && list2 == null)
		{
			return list1;
		}
		
		if(list1 == null && list2 != null) {
			return list2;
		}
		
        if(list2 == null && list1 != null){
			return list1;
		}
        if((list1.val == null && list1.next == null) ||
            list2.val == null && list2.next == null)
        {
            return list1;
        }
     
		ListNode result = new ListNode();
		ListNode head = result;
		while (list1 != null && list2 != null)
		{
			ListNode temp;
			if (list1.val <= list2.val)
			{
				temp = new ListNode(list1.val,list1.next);
				result.next = temp;
				list1 = list1.next;
			}
			else
			{
				temp = new ListNode(list2.val,list2.next);
				result.next = temp;
				list2 = list2.next;
			}
			result= result.next;
		}
		if(list1 != null){
			result.next = list1;
		}
		if(list2 != null){
			result.next = list2;
		}
		return head.next;
    }
}
// @lc code=end

