<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	string encode = RunningLenEncoder("ABBCDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDEAAEF");
	encode.Dump();
}

public string RunningLenEncoder(string str){
	
	string encoderStr= null;
	int counter = 0;
	char counerChar=' ';
	int i =0;
	if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
	{
		return "Input is empty or null";
	}
	foreach (char element in str)
	{
		if(counter == 0){
			counter +=1;
			counerChar = element;
		}
		else
		{
			if(counerChar == element){
				counter +=1;
			}
			else{
				encoderStr += counter.ToString()+counerChar;
				counter = 1;
				counerChar = element;
			}
		}
	}
	
	encoderStr += counter.ToString()+counerChar;
	return encoderStr;
}
// Define other methods and classes here
