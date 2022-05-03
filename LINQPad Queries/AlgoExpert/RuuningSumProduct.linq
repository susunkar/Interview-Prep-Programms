<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

public class RunningSum
{
	public static int ProductSum(List<object> array)
	{
		var r =sumList(array).Dump();
		return r;
	}

	private static int sumList(List<object> l, int multiplicationcount = 1,int sum =0)
	{
		foreach (object element in l)
		{
			if(element is List<object>)
				{
					var a = sumList((List<object>)element,multiplicationcount+1);
					sum +=a;
				}
			else
			{
				sum += (int)element;
			}
		}
		return sum*multiplicationcount;
	}
}



static void Main()
{
	List<object> objList = new List<object>(){
		5,
		2,
		new List<object>(){7,-1},
		3,
		new List<object>(){6,
							new List<object>(){-13,8},
							4}

	};
	///Sample input: [5,2,[7,-1],3,[6,[-13,8],4]]
	///Sample output: 12 (calculation as : (5+2+2*(7-1)+3+2*(6+3*(-13+8)+4)))
	/// [x,y] is x+y
	/// [x,[y,z]] is x+2y+2z

	objList.Dump();
	var r = RunningSum.ProductSum(objList);
	r.Dump();
}