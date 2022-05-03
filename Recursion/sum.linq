<Query Kind="Program" />

void Main()
{
	sum(new int[] { }).Dump();
	sum(new int[] { 1 }).Dump();
	sum(new int[] { 1, 5 }).Dump();
	sum(new int[] { 1, 5, 7 }).Dump();
	sum(new int[] { 1, 5, 7, -2}).Dump();

}
public int sum(int[] num){
	//if(num == null || num.Length == 0) return 0;
	//
	//return num[0] + sum(num.Skip(1).ToArray());
	
	return _sum(num, 0);
}

public int _sum(int[] num, int idx)
{
	if(idx == num.Length) return 0;
	
	return num[idx] + _sum(num,idx+1);
}

