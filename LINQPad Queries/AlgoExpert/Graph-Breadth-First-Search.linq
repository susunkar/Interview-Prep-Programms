<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
    /// <summary>
    /// Breadth-First Search
    /// [ABCDEFGHIJK]
    ///                 A
    ///          /      |      \
    ///         B       C       D
    ///      /     \         /     \
    ///     E       F       G       H     
    ///          /    \       \
    ///         I       J      K
    /// 
    /// Quequ [B,C,D]
    /// current A
    /// 
    /// </summary>
}



public class GraphNode {
	public string name;
	public List<GraphNode> children = new List<GraphNode >();

	public GraphNode (string name) {
		this.name = name;
	}

	public List<string> BreadthFirstSearch(List<string> array) {
		Queue<GraphNode> queue = new Queue<GraphNode >();

        queue.Enqueue (this);
        
        while(queue.Count > 0){
        	GraphNode  current = queue.Dequeue();
            array.Add(current.name);
            current.children.ForEach(o=> queue.Enqueue(o));
        }
        
        return array;
	}

	public GraphNode  AddChild(string name) {
		GraphNode  child = new GraphNode (name);
		children.Add(child);
		return this;
	}
}

// Define other methods, classes and namespaces here
