<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	Circle c = new Circle();
	c.Draw(10,20);
}

//Templete Patterns
public abstract class Shape
{
	private int _color, _thickness ;
	
	private void PrepareGraphic(int color, int thickness){
		this._color = color;
		this._thickness = thickness;
		"PrepareGraphic".Dump();
	}
	
	public void Draw(int color, int thickness)
	{
		PrepareGraphic(color,thickness);
		doDrawing(color, thickness);
	}
	
	public abstract void doDrawing(int color, int thickness);
}

public class Circle : Shape
{
	
	public override void doDrawing(int color, int thickness)
	{
		
		//This will core implementation
		"Circle doDrawing".Dump();
	}
}
// Define other methods and classes here
