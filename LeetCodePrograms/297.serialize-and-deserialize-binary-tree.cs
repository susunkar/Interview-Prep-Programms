/*
 * @lc app=leetcode id=297 lang=csharp
 *
 * [297] Serialize and Deserialize Binary Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
    List<string> nodeList = new List<string>();
	int start =0;
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if (root == null)
		{
			nodeList.Add("#");
			return string.Empty;
		}
		nodeList.Add(root.val.ToString());

		serialize(root.left);
		serialize(root.right);
		
		return String.Join(",",nodeList);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if( string.IsNullOrEmpty(data)) return null;
		List<string> nodedata = data.Split(",").ToList();
		
		TreeNode root = deserializedata(nodedata);
		
		return root;
    }
    private TreeNode deserializedata(List<string> nodeList){
		if(nodeList.Count ==0) return null;
		string val = nodeList[start];start++;
		if(val =="#") {
			return null ;
		}
		
		TreeNode t = new TreeNode(int.Parse(val));
		t.left = deserializedata(nodeList);
		t.right = deserializedata(nodeList);
		return t;
	}
        
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
// @lc code=end

