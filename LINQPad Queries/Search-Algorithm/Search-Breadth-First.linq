<Query Kind="Program">
  <Namespace>System</Namespace>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	var friendsList = new Dictionary<string, List<string>>{
		{"you", new List<string> {"alice","bob", "claire"}},
		{"bob", new List<string> {"anuj", "peggy"}},
		{"alice", new List<string> {"peggy"}},
		{"claire", new List<string> {"thom","jonny"}}
	};

	SearchMangoSeller(friendsList).Dump();
}
public bool SearchMangoSeller (Dictionary<string, List<string>> friendsList )
{
	Queue  search_queue =  new Queue();
	foreach (var p in friendsList["you"])
	{
		search_queue.Enqueue(p);
	}
	var searchedPersion = new List<string>();
	
	while (search_queue.Count > 0)
	{
		var person = search_queue.Dequeue();
		if(!searchedPersion.Any(c=>c.Equals(person.ToString())))
		{
			if (IsMangoSeller(person.ToString()))
			{
				"Mango Seller".Dump();
				return true;
			}
			else {
				
				searchedPersion.Add(person.ToString());
				if (friendsList.ContainsKey(person.ToString()))
				{
					foreach (var p in friendsList[person.ToString()])
					{
						search_queue.Enqueue(p);
					}
				}
			}
		}
	}
	return false;
}

bool IsMangoSeller(string person)
{
	return person.EndsWith("m");
}

// Define other methods and classes here