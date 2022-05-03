/*
 * @lc app=leetcode id=530 lang=csharp
 *
 * [530] Minimum Absolute Difference in BST
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
    public int GetMinimumDifference(TreeNode root) {
        List<int> nodesValue = new List<int>();
        InOrderTravel(root,nodesValue);
        int minDiff = int.MaxValue;
        for(int i =1; i<nodesValue.Count;i++){
            int diff = nodesValue[i]- nodesValue[i-1];
            if(diff<minDiff){
                minDiff =diff;
            }
        }
        return minDiff;
    }
    public void InOrderTravel(TreeNode node, List<int> nodesValue){
        if(node == null) return;

        InOrderTravel(node.left,nodesValue);
        nodesValue.Add(node.val);
        InOrderTravel(node.right,nodesValue);

    }
}
// @lc code=end

