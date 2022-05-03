<Query Kind="Program" />


void Main()
{
	Codec t = new Codec();
	TreeNode root = new TreeNode(20);
	root = new TreeNode(20);
	root.left = new TreeNode(8);
	//root.right = new TreeNode(22);
	root.left.left = new TreeNode(4);
	root.left.right = new TreeNode(12);
	root.left.right.left = new TreeNode(10);
	root.left.right.right = new TreeNode(14);
	
	root.Dump();
	Codec s = new Codec();
	string d = s.serialize(root);
	d.Dump();
	s.deserialize(d).Dump();
}
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
	public TreeNode(int x) { val = x; }
}
public class Codec
{
	StringBuilder serializeTree = new StringBuilder();
	List<string> nodeList = new List<string>();
	int start =0;
	// Encodes a tree to a single string.
	public string serialize(TreeNode root)
	{
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

	//Decodes your encoded data to tree.
	public TreeNode deserialize(string data)
	{
		if( string.IsNullOrEmpty(data)) return null;
		List<string> nodedata = data.Split(",").ToList();
		
		return deserializedata(nodedata);
	}
	public TreeNode deserializedata(List<string> nodeList){
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

// You can define other methods, fields, classes and namespaces here