<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>SmartFormat.NET</NuGetReference>
  <Namespace>Excel = Microsoft.Office.Interop.Excel</Namespace>
  <Namespace>Outlook = Microsoft.Office.Interop.Outlook</Namespace>
  <Namespace>PowerPoint = Microsoft.Office.Interop.PowerPoint</Namespace>
  <Namespace>Word = Microsoft.Office.Interop.Word</Namespace>
</Query>

void Main()
{
	/*
		Node Depth: distance from root to node, root depth is 0
	*/
}
public static void InvertBinaryTree(BinaryTree tree){
	List<BinaryTree> queue = new List<BinaryTree>();
	queue.Add(tree);
	
	int index =0;
	
	while(index < queue.Count){
		
		BinaryTree current = queue[index];
		
		index +=1;
		if(current == null){
			continue;
		}
		swapLeftAndRight(current);
		if(current.left != null){
			queue.Add(current.left);
		}
		if(current.right != null){
			queue.Add(current.right);
		}
	}
}
private static void swapLeftAndRight(BinaryTree tree){
	BinaryTree left = tree.left;
	tree.left = tree.right;
	tree.right = left;
}
public class BinaryTree
{
	public int value;
	public BinaryTree left;
	public BinaryTree right;

	public BinaryTree(int value)
	{
		this.value = value;
	}
}
// Define other methods, classes and namespaces here
