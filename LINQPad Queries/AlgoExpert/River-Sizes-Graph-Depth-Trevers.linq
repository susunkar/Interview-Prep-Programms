<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
    /// <summary>
    /// River-Sizes (Graph Depth-Trevers search)
    /// 
    /// Time : O(Width * Height)
    ///        O(N)
    /// Space : O(Width * Height)
    /// 
    /// Rivers Matrix 
    /// 1 O O 1 O
    /// 1 O 1 O O
    /// O O 1 O 1
    /// 1 O 1 O 1
    /// 1 O 1 1 O
    /// 
    /// output river size: [1,2,2,2,5]
    /// </summary>

    int [,] input = {
            {1, 0, 0, 1, 0},
            {1, 0, 1, 0, 0},
            {0, 0, 1, 0, 1},
            {1, 0, 1, 0, 1},
            {1, 0, 1, 1, 0},
        };
    int[] expected = { 1, 2, 2, 2, 5 };
    List<int> output = RiverSizes (input);
    output.Sort();
    output.Dump();
}
public static List<int> RiverSizes(int[,] matrix){
    List<int> sizes = new List<int>();
    bool[,] visited = new bool[matrix.GetLength(0),matrix.GetLength(1)];
    
    for(int i = 0; i<matrix.GetLength(0); i++){
        for(int j =0 ; j<matrix.GetLength(1); j++){
            if(visited[i,j]){
                continue;
            }
            traverseNode(i,j, matrix, visited, sizes);
        }
    }
    return sizes;
}
public static void traverseNode(int i, int j, int[,] matrix, bool [,] visited, List<int> sizes){
    int currentRiverSize =0;
    Stack<int[]> nodesToExplore = new Stack<int[]>();
    
    nodesToExplore.Push(new int[] {i,j});
    
    while(nodesToExplore.Count !=0){
        int[] currentNode = nodesToExplore.Pop();
        
        i = currentNode[0];
        j = currentNode[1];
        
        if(visited[i,j]){
            continue;
        }
        visited [i,j] = true;
        
        if(matrix[i,j] ==0){
            continue;
        }
        
        currentRiverSize ++;
        List<int[]> unvisitedNeighbours = getUnivisitedNeighbours(i,j, matrix, visited);
        foreach(var neighbor in unvisitedNeighbours){
            nodesToExplore.Push(neighbor);
        }
    }
    if(currentRiverSize > 0){
        sizes.Add(currentRiverSize);
    }
}

private static List<int []> getUnivisitedNeighbours (int i, int j, int [,] matrix, bool [,] visited)
{
    List<int[]> unvisitedNeighbours = new List<int[]>();
    if (i > 0 && !visited [i - 1, j])
    {
        unvisitedNeighbours.Add (new int[] {i-1,j});
    }
    if(i< matrix.GetLength(0) -1 && !visited[i+1,j]){
        unvisitedNeighbours.Add(new int[] { i+1, j});
    }
    if (j > 0 && !visited [i, j - 1])
    {
        unvisitedNeighbours.Add (new int[] {i,j -1});
    }
    if(j < matrix.GetLength(1) -1 && !visited[i,j+1]){
        unvisitedNeighbours.Add(new int[] {i,j+1});
    }
    return unvisitedNeighbours;
}


// Define other methods, classes and namespaces here
