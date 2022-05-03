/*
 * @lc app=leetcode id=230 lang=csharp
 *
 * [230] Kth Smallest Element in a BST
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int counter =1;
    int value =0;
    public int KthSmallest(TreeNode root, int k) {
       
        InOrderTravel(root,k);
        return value;
    }
    public void InOrderTravel(TreeNode node, int k){
        if(node == null) return ;
        
        InOrderTravel(node.left,k);
        if(k==counter) {
            value = node.val;
        }
        counter++;
        InOrderTravel(node.right,k);
    }

}
// @lc code=end

