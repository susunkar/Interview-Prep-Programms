<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

void Main()
{
    /// <summary>
    /// Merge Sort
    /// O(n log(n) time | O(n log(n)) space
    /// 
    /// </summary>
}

public static int[] MergeSort (int[] array)
{
    if (array.Length <= 1)
    {
        return array;
    }
    int middleIdx = array.Length / 2;
    int[] leftHalf = array.Take (middleIdx).ToArray();
    int[] rightHalf = array.Skip (middleIdx).ToArray();
    return mergeSortedArrays (MergeSort (leftHalf), MergeSort (rightHalf));
}
public static int[] mergeSortedArrays (int[] leftHalf, int[] rightHalf)
{
    int[] sortedArray = new int [leftHalf.Length + rightHalf.Length];
    int k = 0;
    int i = 0;
    int j = 0;
    while (i < leftHalf.Length && j < rightHalf.Length)
    {
        if (leftHalf [i] <= rightHalf [j])
        {
            sortedArray [k++] = leftHalf [i++];
        }
        else
        {
            sortedArray [k++] = rightHalf [j++];
        }
    }
    while (i < leftHalf.Length)
    {
        sortedArray [k++] = leftHalf [i++];
    }
    while (j < rightHalf.Length)
    {
        sortedArray [k++] = rightHalf [j++];
    }
    return sortedArray;
}

//-------------------------------------------------------------------------
public static int[] MergeSortV2 (int[] array)
{
    if (array.Length <= 1)
    {
        return array;
    }
    int[] auxiliaryArray = (int[])array.Clone();
    MergeSort (array, 0, array.Length - 1, auxiliaryArray);
    return array;
}
public static void MergeSort (int[] mainArray, int startIdx, int endIdx, int[] auxiliaryArray)
{
    if (startIdx == endIdx)
    {
        return;
    }
    int middleIdx = (startIdx + endIdx) / 2;
    MergeSort (auxiliaryArray, startIdx, middleIdx, mainArray);
    MergeSort (auxiliaryArray, middleIdx + 1, endIdx, mainArray);
    doMerge (mainArray, startIdx, middleIdx, endIdx, auxiliaryArray);
}
public static void doMerge (int[] mainArray, int startIdx, int middleIdx, int endIdx,
    int[] auxiliaryArray)
{
    int k = startIdx;
    int i = startIdx;
    int j = middleIdx + 1;
    while (i <= middleIdx && j <= endIdx)
    {
        if (auxiliaryArray [i] <= auxiliaryArray [j])
        {
            mainArray [k++] = auxiliaryArray [i++];
        }
        else
        {
            mainArray [k++] = auxiliaryArray [j++];
        }
    }
    while (i <= middleIdx)
    {
        mainArray [k++] = auxiliaryArray [i++];
    }
    while (j <= endIdx)
    {
        mainArray [k++] = auxiliaryArray [j++];
    }
}
