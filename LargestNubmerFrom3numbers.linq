<Query Kind="Program" />

void Main()
{
	LargestNumber lg = new LargestNumber();
	lg.FindLargestNumber(8,1,9).Dump();
	lg.FindLargestNumber(2,7,4).Dump();
	lg.FindLargestNumber(6,2,5).Dump();
	
}
public class LargestNumber
{
	public int FindLargestNumber(int a, int b, int c){
		int max = a;
		return max<b ? max=b: max<c? max = c: max;
	}
}
// You can define other methods, fields, classes and namespaces here