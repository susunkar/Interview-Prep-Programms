<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>NUnit</NuGetReference>
</Query>

public class Program
{
	// This is the class of the input root. Do not edit it.
	public class BinaryTree
	{
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value)
		{
			this.value = value;
			this.left = null;
			this.right = null;
		}
	}
	public static List<int> BranchSums(BinaryTree root)
	{
		// Write your code here.
		List<int> sum = new List<int>();
		TreeTravel(root, 0, sum);
		return sum;
	}
	public static void TreeTravel(BinaryTree root, int runningvalue, List<int> sum)
	{
		if (root == null)
			return;

		var newValue = runningvalue + root.value;
		if (root.left == null && root.right == null)
		{
			sum.Add(newValue);
			return;
		}

		TreeTravel(root.left, newValue, sum);
		TreeTravel(root.right, newValue, sum);
	}

	static void Main()
	{
		ProgramTest.TestBinaryTree tree = new ProgramTest.TestBinaryTree(1).Insert(
		new List<int>(){
			2, 3, 4, 5, 6, 7, 8, 9, 10
			//2, 3, 4, 5
		});

		var sumTree = BranchSums(tree);
		sumTree.Dump();
	}
}


public class ProgramTest
{
	public class TestBinaryTree : Program.BinaryTree
	{
		public TestBinaryTree(int value) : base(value)
		{
		}

		public TestBinaryTree Insert(List<int> values)
		{
			return Insert(values, 0);
		}

		public TestBinaryTree Insert(List<int> values, int i)
		{
			if (i >= values.Count) return null;

			List<TestBinaryTree> queue = new List<TestBinaryTree>();
			queue.Add(this);
			while (queue.Count > 0)
			{
				TestBinaryTree current = queue[0];
				queue.RemoveAt(0);
				if (current.left == null)
				{
					current.left = new TestBinaryTree(values[i]);
					break;
				}
				queue.Add((TestBinaryTree)current.left);
				if (current.right == null)
				{
					current.right = new TestBinaryTree(values[i]);
					break;
				}
				queue.Add((TestBinaryTree)current.right);
			}
			Insert(values, i + 1);
			return this;
		}
	}
}



// Define other methods, classes and namespaces here
