using System;
/*
 * @lc app=leetcode id=543 lang=csharp
 *
 * [543] Diameter of Binary Tree
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
    int diameter = 0;

    public int DiameterOfBinaryTree(TreeNode root) {
        GetBinaryTreeDiamete(root);
        return diameter==0 ? 0 : diameter-1;
    }
    private int GetBinaryTreeDiamete(TreeNode root){
      
        if(root == null) return 0;

        var leftCount =  GetBinaryTreeDiamete(root.left);
        var rightCount = GetBinaryTreeDiamete(root.right);
        
        diameter = Math.Max(diameter, (leftCount + rightCount +1));
        return Math.Max(leftCount,rightCount)+1;
    }
}
// @lc code=end

