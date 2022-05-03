<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

public class Program
{
	// Do not edit the class below except
	// for the DepthFirstSearch method.
	// Feel free to add new properties
	// and methods to the class.
	public class Node
	{
		public string name;
		public List<Node> children = new List<Node>();

		public Node(string name)
		{
			this.name = name;
		}

		public List<string> DepthFirstSearch(List<string> array)
		{
			array.Add(name);
			// Write your code here.

			foreach (var c in children)
			{
				c.DepthFirstSearch(array);
			}
			return array;
		}

		public Node AddChild(string name)
		{
			Node child = new Node(name);
			children.Add(child);
			return this;
		}
		
		static void Main(){

			Program.Node pa = new Node("A");
			pa.AddChild("B");
			pa.AddChild("C");
			pa.AddChild("D");

			pa.children[0].AddChild("E").AddChild("F");
			pa.children[2].AddChild("G").AddChild("H");
			
			pa.children[0].children[1].AddChild("I").AddChild("J");
			pa.children[2].children[0].AddChild("K");

			//pa.Dump();
			//Out Put: A,B,E,F,I,J,C,D,G,K
			var r = pa.DepthFirstSearch(new List<string>());
			r.Dump();

		}

	}
}
