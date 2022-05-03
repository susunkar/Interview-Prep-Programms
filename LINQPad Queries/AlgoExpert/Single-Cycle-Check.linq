<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
    /// <summary>
    /// Single Cycle Check
    /// 
    /// array = [2,3,1,-4,-4,2]
    ///  2->3,1
    ///  1->-4
    ///  -4->1,3,2,2
    ///  2->2,3
    ///  3->1
    ///  1->-4
    ///  -4->1,3,2,2 (cycle)
    /// </summary>
}

public static bool HasSingleCycle (int[] array)
{
    int numElementsVisited = 0;
    int currentIdx = 0;
    while (numElementsVisited < array.Length)
    {
        //we are not at starting point but travell all array
        if (numElementsVisited > 0 && currentIdx == 0)
        {
            return false;
        }
        numElementsVisited++;
        currentIdx = getNextIdx (currentIdx, array);
    }
    return currentIdx == 0;
}
public static int getNextIdx (int currentIdx, int[] array)
{
    int jump = array [currentIdx];
    int nextIdx = (currentIdx + jump) % array.Length; // if nextIdx ex 26 is greated then array lenght we need to adj the with in array length

    return nextIdx >= 0 ? nextIdx : nextIdx + array.Length; 
}

// Define other methods, classes and namespaces here
