<Query Kind="Program">
  <NuGetReference>RestClient</NuGetReference>
  <Namespace>Rest</Namespace>
</Query>

void Main()
{

	int[] arry = new int[] {1,2,3,4};
	ArrayRotation(arry).Dump();
	
	static int[] ArrayRotation(int[] arr)
	{
		if (arr == null || arr.Length <= 0) return new int[] {};
		
		int endIdx = arr.Length-1;
		for(int startIdx = 0 ; startIdx <arr.Length/2; startIdx++){
			int tem = arr[endIdx];
			arr[endIdx] = arr[startIdx];
			arr[startIdx] = tem;
			endIdx --;
		}
		return arr;
	}

	ArrayRotationLeft(new int[] {1,2,3,4,5},2).Dump();
	ArrayRotationLeft(new int[] {1,2,3,4,5},-2).Dump();
	
	static int[] ArrayRotationLeft(int[] arr, int shiftPos){
		int[] result = new int[arr.Length];
		if (arr == null || arr.Length <= 0) return new int[] {};
		
		for(int i =0 ; i<arr.Length; i++){
			result[i]=arr[(i + (arr.Length - shiftPos)) % arr.Length];
		}
		return result;
	}
}

// You can define other methods, fields, classes and namespaces here
