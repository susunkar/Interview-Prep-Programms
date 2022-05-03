/*
 * @lc app=leetcode id=199 lang=csharp
 *
 * [199] Binary Tree Right Side View
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
    public IList<int> RightSideView(TreeNode root) {
        if(root == null) return new List<int>();
        
        List<int> rightViewNodes= new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count>0){
            
            int count = queue.Count;

            for(int i=0; i<count;i++){
                TreeNode p = queue.Dequeue();
                if(i==count-1){
                    rightViewNodes.Add(p.val);
                }
                if(p.left!=null){
                    queue.Enqueue(p.left);
                }
                if(p.right!=null){
                    queue.Enqueue(p.right);
                }
            }
        }
        return rightViewNodes.ToList();
    }
}
// @lc code=end

