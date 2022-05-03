<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Youngest Common Ancestor Graph
    /// O(d) time | O(1) space where d is the depth (height) of the ancestral tree
    /// </summary>

    var trees = new Dictionary<char, AncestralTree>();
    var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    foreach (char a in alphabet)
    {
        trees.Add (a, new AncestralTree (a));
    }

    trees ['A'].AddAsAncestor (new AncestralTree[] {
            trees['B'],
            trees['C'],
            trees['D'],
            trees['E'],
            trees['F']
        });

    trees ['A'].AddAsAncestor (new AncestralTree[] { trees ['B'], trees ['C'] });
    trees ['B'].AddAsAncestor (new AncestralTree[] { trees ['D'], trees ['E'] });
    trees ['D'].AddAsAncestor (new AncestralTree[] { trees ['H'], trees ['I'] });
    trees ['C'].AddAsAncestor (new AncestralTree[] { trees ['F'], trees ['G'] });

    AncestralTree yca = GetYoungestCommonAncestor (trees ['A'],
        trees ['E'],
        trees ['I']);
        
     Xunit.Assert.True (yca == trees['B'],"PASS".Dump());
}
public class AncestralTree{
    public char name;
    public AncestralTree ancestor;
    
    public AncestralTree(char name){
        this.name = name;
        this.ancestor = null;
    }
    public void AddAsAncestor(AncestralTree[] descendants){
        foreach (AncestralTree descendant in descendants)
        {
            descendant.ancestor = this;
        }
    }
}

public static AncestralTree GetYoungestCommonAncestor( AncestralTree topAncestor,  AncestralTree descendantOne, AncestralTree descendantTwo){
    
    int depthOne = getDescendantDepth(descendantOne, topAncestor);
    int depthTwo = getDescendantDepth(descendantTwo, topAncestor);
    
    if(depthOne> depthTwo){
        return backtrackAncestralTree(descendantOne, descendantTwo, depthOne- depthTwo);
    }
    else{
        return backtrackAncestralTree(descendantTwo, descendantOne, depthTwo- depthOne);
    }
}

static AncestralTree backtrackAncestralTree (AncestralTree lowerDescendant, AncestralTree higherDescendant, int diff)
{
    while(diff> 0){
        lowerDescendant = lowerDescendant.ancestor;
        diff--;
    }
    
    while(lowerDescendant != higherDescendant){
        lowerDescendant = lowerDescendant.ancestor;
        higherDescendant = higherDescendant.ancestor;
    }
    return lowerDescendant;
}

private static int getDescendantDepth (AncestralTree descendant, AncestralTree topAncestor)
{
    int depth =0;
    while(descendant != topAncestor){
        depth +=1;
        descendant = descendant.ancestor;
    }
    return depth;
}

// Define other methods, classes and namespaces here
