<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <Namespace>System.Windows.Forms.DataVisualization.Charting</Namespace>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Topological Sort (Depth for search solution)
    /// You're given a list of arbitrary jobs that need to be completed; these jobs are represented by disticnt integers,
    /// You're also given a list of dependencies, A dependency is represented as a paire of jobs where the firest job is a prerequisire of the sencond one, in othe words,
    /// the seconds job depends on the first onel it can only be completed once the first job is completed.
    /// time : O(V + E)
    /// space: O(V + E)
    /// </summary>


    List<int> jobs = new List<int>(){
            1, 2, 3, 4
        };
    int [,] depsArray = new int [,] {
            {1, 2}, {1, 3}, {3, 2}, {4, 2}, {4, 3}
        };
    List<int[]> deps = new List<int[]>();
    fillDeps (depsArray, deps);
    List<int> order = TopologicalSort (jobs, deps);
    Xunit.Assert.True (isValidTopologicalOrder (order, jobs, deps) == true,"pass".Dump());
}
void fillDeps (int [,] depsArray, List<int[]> deps)
{
    for (int x = 0; x < depsArray.GetLength (0); x++)
    {
        var arr = new int [depsArray.GetLength (1)];
        for (int y = 0; y < depsArray.GetLength (1); y++)
        {
            arr [y] = depsArray [x, y];
        }
        deps.Add (arr);
    }
}
bool isValidTopologicalOrder (List<int> order, List<int> jobs, List<int[]> deps)
{
    Dictionary<int, bool> visited = new Dictionary<int, bool>();
    foreach (int candidate in order)
    {
        foreach (int[] dep in deps)
        {
            if (candidate == dep [0] &&
              visited.ContainsKey (dep [1])) return false;
        }
        visited.Add (candidate, true);
    }
    foreach (int job in jobs)
    {
        if (!visited.ContainsKey (job)) return false;
    }
    return order.Count == jobs.Count;
}
public static List<int> TopologicalSort (List<int> jobs, List<int[]> deps)
{
    JobGraph jobGraph = createJobGraph (jobs, deps);
    return getOrderedJobs (jobGraph);

}
public static JobGraph createJobGraph (List<int> jobs, List<int[]> deps)
{
    JobGraph graph = new JobGraph (jobs);
    foreach (int[] dep in deps)
    {
        graph.addDep (dep [0], dep [1]);
    }
    return graph;
}
public static List<int> getOrderedJobs (JobGraph graph)
{
    List<int> orderedJobs = new List<int>();
    List<JobNode> nodesWithNoPrereqs = new List<JobNode>();
    foreach (JobNode node in graph.nodes)
    {
        if (node.numOfPrereqs == 0)
        {
            nodesWithNoPrereqs.Add (node);
        }
    }
    while (nodesWithNoPrereqs.Count > 0)
    {
        JobNode node = nodesWithNoPrereqs [nodesWithNoPrereqs.Count - 1];
        nodesWithNoPrereqs.RemoveAt (nodesWithNoPrereqs.Count - 1);
        orderedJobs.Add (node.job);
        removeDeps (node, nodesWithNoPrereqs);
    }
    bool graphHasEdges = false;
    foreach (JobNode node in graph.nodes)
    {
        if (node.numOfPrereqs > 0)
        {
            graphHasEdges = true;
        }
    }
    return graphHasEdges ? new List<int> () : orderedJobs;
}
public static void removeDeps (JobNode node, List<JobNode> nodesWithNoPrereqs)
{
    while (node.deps.Count > 0)
    {
        JobNode dep = node.deps [node.deps.Count - 1];
        node.deps.RemoveAt (node.deps.Count - 1);
        dep.numOfPrereqs--;
        if (dep.numOfPrereqs == 0)
            nodesWithNoPrereqs.Add (dep);
    }
}
public class JobGraph
{
    public List<JobNode> nodes;
    public Dictionary<int, JobNode> graph;

    public JobGraph (List<int> jobs)
    {
        nodes = new List<JobNode> ();
        graph = new Dictionary<int, JobNode> ();

        foreach (int job in jobs)
        {
            addNode (job);
        }
    }

    public void addDep (int job, int dep)
    {
        JobNode jobNode = getNode (job);
        JobNode depNode = getNode (dep);
        jobNode.deps.Add (depNode);
        depNode.numOfPrereqs++;
    }

    public void addNode (int job)
    {
        graph.Add (job, new JobNode (job));
        nodes.Add (graph [job]);
    }

    public JobNode getNode (int job)
    {
        if (!graph.ContainsKey (job)) addNode (job);
        return graph [job];
    }
}
public class JobNode
{
    public int job;
    public List<JobNode> deps;
    public int numOfPrereqs;

    public JobNode (int job)
    {
        this.job = job;
        deps = new List<JobNode>();
        numOfPrereqs = 0;
    }
}
// Define other methods, classes and namespaces here
