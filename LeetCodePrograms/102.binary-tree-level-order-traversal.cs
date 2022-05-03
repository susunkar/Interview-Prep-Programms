/*
 * @lc app=leetcode id=102 lang=csharp
 *
 * [102] Binary Tree Level Order Traversal
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
    public IList<IList<int>> LevelOrder(TreeNode root) {

        if(root == null) {
            return new List<IList<int>>();
        }

        List<IList<int>> levelOrderNodes = new List<IList<int>>();

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count>0){
            List<int> levelNodes = new List<int>();
            int count = q.Count;

            for(int i=0; i<count;i++){
                TreeNode tNode = q.Dequeue();
                levelNodes.Add(tNode.val);

                if(tNode.left != null){
                    q.Enqueue(tNode.left);
                }
                if(tNode.right != null){
                    q.Enqueue(tNode.right);
                }
            }
            levelOrderNodes.Add(levelNodes);
        }
        return levelOrderNodes;
    }
}
// @lc code=end

