<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Dictionary<string, int> ds = new Dictionary<string, int>();
	ds.Add("cat", 2);
	ds.Add("bat", 1);
	ds.Add("rat", 4);
	ds.Add("mat", 3);

	int[] val = new int[] { 3, 1};
	//val.Dump();

	var sort = from v in ds orderby v.Key descending select v;
	//sort.Dump();
	var sort1 = ds.OrderBy(x => x.Value);
	ds.Dump();
    sort1.Dump();

	var d = ds.Where(x=>val.Contains<int>(x.Value));
	d.Dump();
	
}



// Define other methods, classes and namespaces here
