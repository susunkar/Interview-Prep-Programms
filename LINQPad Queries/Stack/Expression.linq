<Query Kind="Program" />

void Main()
{
	Stack<char> operators = new Stack<char>();
	Stack<int> operand = new Stack<int>();

	var key = Console.ReadLine();
	key.Dump();
	var keyChar = key.ToArray();
	int lenght = keyChar.Count();
	int start = 0;
	while(start<lenght){
	 var temp = keyChar[start++];
		switch(temp){
			case '(': break;
			case '+': operators.Push(temp); break;
			case '-': operators.Push(temp); break;
			case '*': operators.Push(temp); break;
			case ')':
					{
						int v = operand.Pop();
						int v1 = operand.Pop();
						char o = operators.Pop();
						int r =0;
						Console.WriteLine("{0} {1} {2}",v1,o,v);
							switch(o){
								case '+': r = v1 + v ; operand.Push(r); r.Dump(); break;
								case '-': r = v1 - v ; operand.Push(r); r.Dump(); break;
								case '*': r = v1 * v; operand.Push(r); r.Dump(); break;
							}
					} break;
			default: operand.Push(int.Parse(temp.ToString()));
			break;
		}
	}
	operand.Pop().Dump();
}

// Define other methods and classes here
