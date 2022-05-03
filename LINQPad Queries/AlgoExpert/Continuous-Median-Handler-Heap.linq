<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>NUnit</NuGetReference>
  <NuGetReference>xunit.assert</NuGetReference>
  <Namespace>Microsoft.VisualBasic.CompilerServices</Namespace>
</Query>

void Main()
{
    /// <summary>
    /// Continuous Median Handler by Heap
    /// </summary>
    
    ContinuousMedianHandler handler = new ContinuousMedianHandler();
    handler.Insert (5);
    handler.Insert (10);
    Xunit.Assert.True (handler.GetMedian() == 7.5,"PASS".Dump());
    handler.Insert (100);
    Xunit.Assert.True(handler.GetMedian() == 10,"PASS".Dump());

}
public class ContinuousMedianHandler
{
    public Heap lower;
    public Heap greater;
    public double median = 0;

    public ContinuousMedianHandler()
    {
        this.lower = new Heap (Heap.MAX_HEAP_FUNC, new List<int> ());
        this.greater = new Heap (Heap.MIN_HEAP_FUNC, new List<int> ());
        this.median = 0;
    }
    public void Insert (int number)
    {
        if (lower.length == 0 || number < lower.Peek())
        {
            this.lower.Insert (number);
        }
        else
        {
            this.greater.Insert (number);
        }
        this.reBalanceHeaps();
        this.upDateMedian();
    }
    public void reBalanceHeaps()
    {
        if (lower.length - greater.length == 2)
        {
            this.greater.Insert (this.lower.Remove());
        }
        else
        {
            if (greater.length - lower.length == 2)
            {
                this.lower.Insert (this.greater.Remove());
            }
        }
    }
    public void upDateMedian()
    {
        if (lower.length == greater.length)
        {
            median = ((double)lower.Peek() + (double)greater.Peek()) / 2;
        }
        else
        {
            if (lower.length > greater.length)
            {
                median = lower.Peek();
            }
            else
            {
                median = greater.Peek();
            }
        }
    }

    public double GetMedian()
    {
        return median;
    }
}

public class Heap
{
    public List<int> heap = new List<int>();
    public Func<int, int, bool> comparisonFunc;
    public int length;

    public Heap (Func<int, int, bool> func, List<int> array)
    {
        this.comparisonFunc = func;
        this.heap = buildHeap (array);
        this.length = array.Count;
    }

    public int Peek()
    {
        // Write your code here.
        return heap [0];
    }
    public int Remove()
    {
        this.Swap (0, heap.Count - 1);
        int valueToRemove = heap [heap.Count - 1];
        this.heap.RemoveAt (heap.Count - 1);
        this.length -= 1;
        siftDown (0, heap.Count - 1, heap);

        return valueToRemove;
    }
    public void Insert (int value)
    {
        this.heap.Add (value);
        this.length += 1;
        this.siftUp (heap.Count - 1, heap);
    }
    public List<int> buildHeap (List<int> array)
    {
        int firstParentIdx = (array.Count - 2) / 2;
        for (int currentIdx = firstParentIdx; currentIdx >= 0; currentIdx--)
        {
            this.siftDown (currentIdx, array.Count - 1, array);
        }
        return array;
    }

    public void siftDown (int currentIdx, int endIdx, List<int> heap)
    {
        int childOneIdx = currentIdx * 2 + 1;
        while (childOneIdx <= endIdx)
        {
            int childTwoIdx = currentIdx * 2 + 2 <= endIdx ? currentIdx * 2 + 2 : -1;

            int idxToSwap;
            if (childTwoIdx != -1)
            {
                if (comparisonFunc (heap [childTwoIdx], heap [childOneIdx]))
                {
                    idxToSwap = childTwoIdx;
                }
                else
                {
                    idxToSwap = childOneIdx;
                }
            }
            else
            {
                idxToSwap = childOneIdx;
            }
            if (comparisonFunc (heap [idxToSwap], heap [currentIdx]))
            {
                Swap (currentIdx, idxToSwap);
                currentIdx = idxToSwap;
                childOneIdx = currentIdx * 2 + 1;
            }
            else
            {
                return;
            }
        }
    }

    public void siftUp (int currentIdx, List<int> heap)
    {
        int parentIdx = (currentIdx - 1) / 2;
        while (currentIdx > 0)
        {
            if (comparisonFunc (heap [currentIdx], heap [parentIdx]))
            {
                Swap (currentIdx, parentIdx);
                currentIdx = parentIdx;
                parentIdx = (currentIdx - 1) / 2;
            }
            else
            {
                return;
            }
        }
    }

    void Swap (int currentIdx, int parentIdx)
    {
        int temp = this.heap [currentIdx];
        this.heap [currentIdx] = heap [parentIdx];
        this.heap [parentIdx] = temp;
    }
    public static bool MAX_HEAP_FUNC (int a, int b)
    {
        return a > b;
    }
    public static bool MIN_HEAP_FUNC (int a, int b)
    {
        return a < b;
    }

}
// Define other methods, classes and namespaces here
