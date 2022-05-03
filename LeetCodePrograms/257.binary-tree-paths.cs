/*
 * @lc app=leetcode id=257 lang=csharp
 *
 * [257] Binary Tree Paths
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
    List<string> treepath = new List<string>();
    public IList<string> BinaryTreePaths(TreeNode root) {

        InOrderTreeTravel(root, "");
        return treepath;
    }
    public void InOrderTreeTravel(TreeNode node,string path){
       if(node == null ) return;
       
       if(node.left == null && node.right == null){
            treepath.Add(path + node.val);
       }

        string pt = path + node.val+"->";
        InOrderTreeTravel(node.left, pt);
        InOrderTreeTravel(node.right, pt);
    }
}
// @lc code=end

