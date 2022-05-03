/*
 * @lc app=leetcode id=404 lang=csharp
 *
 * [404] Sum of Left Leaves
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
     int sum = 0;
    public int SumOfLeftLeaves(TreeNode root) {
        leftSum(root, false);
        return sum;
    }
    public void leftSum(TreeNode node,bool isLeft){
        if(node == null) return ;
        if(node.left ==null && node.right == null && isLeft){
            sum= sum +node.val;
        }
        leftSum(node.left, true);
        leftSum(node.right, false);
    }
}
// @lc code=end

