<Query Kind="Program" />

void Main()
{
	//sqrtx(16).Dump();
	Enumerable.Repeat('D', 5).Dump();
}
static int sqrtx(int number){
	if(number <=1) return number;
	int low = 1; 
	int right = number;
	int mid = 0;
	while(low<right){
		 mid = low + (right - low)/2;
		if((mid * mid) <= number){
			return mid;
		}
		if(mid * mid > number){
			right = mid-1;
		}
		else {
			low = mid +1;
		}
	}
	return mid;
}

// You can define other methods, fields, classes and namespaces here