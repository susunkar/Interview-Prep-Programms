<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = new int[] {1, 2, 3, 4,5}; // output: 5,1,2,3,4
	rotLeft(a, -4);
}
static void rotLeft(int[] a, int d)
{
	int[] destinationId = new int[a.Length];
	int[] final = new int[a.Length];
	
	for (int i = 0; i < a.Length; i++) {
		destinationId[i] =a[(i+(a.Length-d)) % a.Length];
	}
    destinationId.Dump();

	
}
// Define other methods, classes and namespaces here