/*
 * @lc app=leetcode id=958 lang=csharp
 *
 * [958] Check Completeness of a Binary Tree
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
    public bool IsCompleteTree(TreeNode root) {
        Queue<TreeNode> BFS = new Queue<TreeNode>();

        BFS.Enqueue(root);
        bool end = false;
        while(BFS.Count > 0){
            TreeNode cur = BFS.Dequeue();
            if(cur == null){
                end = true;
            }
            else{
                if(end) return false;
                BFS.Enqueue(cur.left);
                BFS.Enqueue(cur.right);
            }
        }
        return end;
    }
}
// @lc code=end

