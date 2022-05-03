<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	Pixel[,] DisplayScreen = new Pixel[5,20];
	int rows = DisplayScreen.GetLength(0);
	int columns = DisplayScreen.GetLength(1);
#region
	var chars = "abc";
	var stringChars = new char[1];
	var random = new Random();
	
	for (int r = 0; r < rows; r++)
	{
		for (int c = 0; c < columns; c++)
		{
			for (int i = 0; i < stringChars.Length; i++)
			{
				stringChars[i] = chars[random.Next(chars.Length)];
			}
			Pixel t = new Pixel(new String(stringChars));
			DisplayScreen[r,c] = t;
		}

	}
#endregion	
	Display(DisplayScreen);
	FillPaintColor(DisplayScreen,3,10,"b","x");
	"Out".Dump();
	Display(DisplayScreen);
}

public class Pixel 
{
	private string _color ;
	
	public Pixel(string color){
		this._color = color;
	}
	
	public string GetColor(){
		return this._color;
	}

	public void SetColor(string newColor){
		this._color = "*";
	}
}

public void FillPaintColor(Pixel[,] DisplayScreen, int x, int y, string originalColor, string newColor)
{
	int row = DisplayScreen.GetLength(0);
	int col = DisplayScreen.GetLength(1);
	
	if(x<0 || y <0 || x>= row|| y >= col)
		return;
	if(DisplayScreen[x,y].GetColor() != originalColor )
		return;

	if (DisplayScreen[x, y].GetColor() == originalColor)
	{
		DisplayScreen[x, y].SetColor(newColor);

		FillPaintColor(DisplayScreen, x - 1, y, originalColor, newColor);
		FillPaintColor(DisplayScreen, x, y - 1, originalColor, newColor);
		FillPaintColor(DisplayScreen, x + 1, y, originalColor, newColor);
		FillPaintColor(DisplayScreen, x, y + 1, originalColor, newColor);
	}
}
public void Display(Pixel[,] DisplayScreen)
{
	int rows = DisplayScreen.GetLength(0);
	int columns = DisplayScreen.GetLength(1);

	for (int r = 0; r < rows; r++)
	{
		for (int c = 0; c < columns; c++)
		{
			Console.Write("{0}", DisplayScreen[r, c].GetColor());
		}
		Console.WriteLine();
	}
}