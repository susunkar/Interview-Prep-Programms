<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	/*
		Check expressionis closed properly 
		ex: {[(){[([])]}}
		
	*/
	IsExpressionValied("{[(){[([])]}]}]").Dump();;
}

static bool IsExpressionValied(string expression)
{
	Stack<char> stk = new Stack<char>();
	char[] exp = expression.ToArray();

	for (int i =0;i< exp.Length;i++)
	{
		switch(exp[i]){
			case '(': 
			case '{':
			case '[':
				stk.Push(exp[i]);
				break;
			case ')':
			case '}':
			case ']':

				//we need to check the stack is not empty for pop.
				//senario if right parants are but not left paranthesis 
				if (stk.Count == 0) { 
				Console.WriteLine("{0} ", exp[i]);
				return false;}
				
				char open = stk.Pop();
				Console.WriteLine("{0} {1}", open, exp[i]);
				
				if(IsOpenTerm(open, exp[i]))
					continue;
				else { 
					
					return false;
				}
		}
	}
	return true;
}

static bool IsOpenTerm(char open, char close)
{
	Dictionary<char, char> token = new Dictionary<char, char>(){
	{'(', ')'},
	{'[', ']'},
	{'{', '}'},
	};
	
	char maching=default;
	
	token.TryGetValue(open, out maching);
	
	return (maching == close)? true : false;
}

// Define other methods and classes here
