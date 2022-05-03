<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	cell lnk = new cell();
	cell new_cell = new cell{
		value="A",
		next = null
	};
	lnk.value = "a";
	lnk.next = new cell{
		value = "b",
		next = new cell {
			value = "c",
			next=null
		}
	};
	
	Display(lnk);
//	AddCellInMiddle(lnk,new_cell);
//	AddCellBefore(lnk,new_cell);
//	Display(lnk);
//	DeleteCellInMiddel(lnk);
	DeleteCellInBeganing(lnk);
	Display(lnk);
}
void DeleteCellInBeganing(cell lnk)
{
	lnk=lnk.next;
	var current = lnk;
	Console.WriteLine("");
	while (current != null)
	{
		Console.Write(current.value + "->");
		current = current.next;
	}

}
void DeleteCellInMiddel(cell lnk)
{
	var current = lnk;
	while (current != null)
	{
		if(current.next !=null && current.next.value == "b"){
			current.next = current.next.next;
		}
		current = current.next;
	}
}

public class cell
{
	public string value ;
	public cell next;
}

public void Display(cell lnk)
{
	Console.WriteLine("");
	var current = lnk;
	while (current != null)
	{
		Console.Write(current.value +"->");
		current = current.next;
	}
}
public void  AddCellBefore(cell lnk, cell new_cell)
{
	Console.WriteLine("");
	new_cell.next = lnk;
	var current = new_cell;
	while (current != null)
	{
		Console.Write(current.value + "->");
		current = current.next;
	}
}
public cell AddCellInMiddle(cell lnk, cell new_cell)
{
	//Add in Cell in Middle
	var current = lnk;
	while (current != null)
	{
		if (current.value == "a")
		{
			new_cell.next = current.next;
			lnk.next = new_cell;
		}
		current = current.next;
	}
	return lnk;
}
// Define other methods and classes here
