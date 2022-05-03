/*
 * @lc app=leetcode id=104 lang=csharp
 *
 * [104] Maximum Depth of Binary Tree
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
    public int MaxDepth(TreeNode root) {
      return maxDepth(root, 0);

    }
    public int maxDepth(TreeNode root, int level){
        if(root == null ) return level;

        level ++;
        return Math.Max(maxDepth(root.left, level), maxDepth(root.right, level));
    }
}
// @lc code=end

