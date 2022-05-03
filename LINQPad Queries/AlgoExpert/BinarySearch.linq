<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	
	int[] a = new int[] { 0,1,21,33,45,45,61,71,72,73};
	var r = Program.BinarySearch(a,74);
	r.Dump();
}
public class Program
{
	public static int BinarySearch(int[] array, int target)
	{
		// Write your code here.
		if (array.Length < 0)
			return -1;

		var tagetIndex = Search(array, 0, array.Length - 1, target);

		return tagetIndex;
	}
	public static int Search(int[] array, int start, int end, int target)
	{
		if (start == end && array[start] != target) return -1;

		int middle = (start + end) / 2;

		if (array[middle] == target) return middle;

		if (array[middle] > target)
			return Search(array, start, middle-1, target);
		else
			return Search(array, middle+1, end, target);

	}
}