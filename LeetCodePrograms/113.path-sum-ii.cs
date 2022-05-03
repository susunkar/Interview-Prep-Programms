/*
 * @lc app=leetcode id=113 lang=csharp
 *
 * [113] Path Sum II
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
    List<IList<int>> pathSum = new List<IList<int>>();
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        List<int> leafPath = new List<int>();
        CalculatePathSum(root,leafPath,targetSum);

        return pathSum;
    }

    public void CalculatePathSum(TreeNode root, List<int> leafPath, int sum) {
        if(root == null) return;

        leafPath.Add(root.val);

        if(sum-root.val == 0 && root.left == null && root.right == null){
            
            pathSum.Add(leafPath);
            return;
        }
        CalculatePathSum(root.left,new List<int>(leafPath), sum-root.val);
        CalculatePathSum(root.right,new List<int>(leafPath), sum-root.val);
    }
}
// @lc code=end

