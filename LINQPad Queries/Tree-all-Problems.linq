<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    Node f= new Node('F');
    Node b= new Node('B');
    Node g= new Node('G');
    Node a= new Node('A');
    Node d= new Node('D');
    Node i= new Node('I');
    Node c= new Node('C');
    Node e= new Node('E');
    Node h= new Node('H');
   
    f.setLeftNode(b);
    f.setRightNode(g);
    
    b.setLeftNode (a);
    b.setRightNode (d);
    
    g.setRightNode (i);

    d.setLeftNode (c);
    d.setRightNode (e);
    
    i.setLeftNode (h);
    
    tree hd = new tree(f);
    hd.DFS();
    Console.WriteLine("BFS Order");
    hd.BFS();
    Console.WriteLine();
    Console.WriteLine ("Reverse Order");
    hd.ReversOrder();

    Console.WriteLine();
    Console.WriteLine ("HasPath Sum");
    hd.PathSum(201);
    hd.PathSum(271);
    hd.PathSum(273);
    hd.PathSum(286);
    hd.PathSum(70);
    hd.PathSum(204);

    Console.WriteLine();
    Console.WriteLine ("Max Sum Path Order");
    List<int> set = new List<int>() {0, int.MinValue};
    List<int> result = hd.MaxSumPath(set);
    
    //Console.WriteLine();
    //Console.WriteLine ("Mirror Order");
    //hd.Mirror();
    hd.Dump();
}

public class Node{
   public char value;
   public Node left ;
   public Node right;
   
   public Node(char value){
       this.value = value;
       this.left = null;
       this.right = null;
   }
   
   public int getValue (){
       return value;
   }
   public void setLeftNode(Node lf){
       this.left = lf;
   }
   public void setRightNode(Node rt){
       this.right = rt;
   }
   
   public Node getLeftNode(){
       return this.left;
   }
   public Node getRightNode(){
       return this.right;
    }
}
public class tree
{
    public Node Head;

    public tree (Node hd)
    {
        this.Head = hd;
    }
    public void DFS()
    {
        Console.WriteLine ("Pre Order");
        PreOrderDFS (Head);
        Console.WriteLine();
        Console.WriteLine ("In Order");
        InorderDFS (Head);
        Console.WriteLine();
        Console.WriteLine ("Post Order");
        PostOrderDFS (Head);
        Console.WriteLine();
    }

    void PostOrderDFS (Node hd)
    {
        if (hd == null)
        {
            return;
        }
        PostOrderDFS (hd.getLeftNode());
        PostOrderDFS (hd.getRightNode());
        Console.Write ($"{hd.value} ({(int)hd.value})-->");
    }

    void InorderDFS (Node hd)
    {
        if (hd == null)
        {
            return;
        }
        InorderDFS (hd.getLeftNode());
        Console.Write ($"{hd.value} ({(int)hd.value})-->");
        InorderDFS (hd.getRightNode());
    }

    private void PreOrderDFS (Node hd)
    {
        if (hd == null)
        {
            return;
        }
        Console.Write ($"{hd.value} ({(int)hd.value})-->");
        PreOrderDFS (hd.getLeftNode());
        PreOrderDFS (hd.getRightNode());
    }

    internal void BFS()
    {
        BreadthFirtSearch (Head);
    }

    private void BreadthFirtSearch (Node head)
    {
        if (head == null)
        {
            return;
        }
        Queue<Node> q = new Queue<UserQuery.Node>();
        q.Enqueue (head);
        while (q.Count > 0)
        {
            Node t = q.Dequeue();
            Console.Write ($"{t.value} ({(int)t.value})-->");
            if (t.getLeftNode() != null)
            {
                q.Enqueue (t.getLeftNode());
            }
            if (t.getRightNode() != null)
            {
                q.Enqueue (t.getRightNode());
            }
        }
    }

    internal void Mirror()
    {
        CreateMirrorTree (Head);
        InorderDFS (Head);
    }

    void CreateMirrorTree (Node head)
    {
        if (head == null)
        {
            return;
        }
        CreateMirrorTree (head.getLeftNode());
        CreateMirrorTree (head.getRightNode());

        Node t = head.getLeftNode();
        head.setLeftNode (head.getRightNode());
        head.setRightNode (t);
    }

    internal void ReversOrder()
    {
        ReversOrderTree (Head);
    }

    private void ReversOrderTree (Node head)
    {
        if (head == null)
        {
            return;
        }
        ReversOrderTree (head.getRightNode());
        Console.Write ($"{head.value} ({(int)head.value})-->");
        ReversOrderTree (head.getLeftNode());

    }

    internal void PathSum (int sum)
    {
        List<int> sumNodes = new List<int>();
        var findResult = FindPathSum (Head, sum, sumNodes);
        findResult.Dump ("Sum Path");
        Console.WriteLine ($"Total {sum}");
        foreach (var element in sumNodes)
        {
            Console.Write ($"{element}, ");
        }

    }

    private bool FindPathSum (Node head, int sum, List<int> nodeList)
    {
        if (head == null)
        {
            return sum == 0;
        }
        nodeList.Add (head.value);
        var lt = FindPathSum (head.getLeftNode(), sum - head.value, nodeList);
        var rt = FindPathSum (head.getRightNode(), sum - head.value, nodeList);
        if (lt == true || rt == true)
        {
            return true;
        }
        else
        {
            nodeList.Remove (head.value);
            return false;
        }

    }
    internal List<int> MaxSumPath (List<int> set)
    {
        return MaxSumPath (Head);
    }
    internal List<int> MaxSumPath (Node hd)
    {
        if (hd == null)
        {
            return new List<int> () { 0, Int32.MinValue };
        }

        List<int> ltsum = MaxSumPath (hd.getLeftNode());
        var lfchild = ltsum [0];
        var lfpath = ltsum [1];


        List<int> rtsum = MaxSumPath (hd.getRightNode());
        var rtchild = rtsum [0];
        var rtpath = rtsum [1];

        var child = Math.Max (lfchild, rtchild);
        var maxchildroot = Math.Max (child + hd.value , hd.value);

        var path = Math.Max (lfchild + hd.value + rtchild, maxchildroot);
        
        var maxpath = Math.Max (lfpath, Math.Max (path, rtpath));
 
        return new List<int> (){maxchildroot,maxpath};
        
    }


}
// You can define other methods, fields, classes and namespaces here
