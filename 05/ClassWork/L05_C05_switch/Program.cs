using System;

class Program
{
	enum Color { Red, Green, Blue }

	static void Main()
	{
		Color c = (Color)(new Random()).Next(0, 4);
		switch (c)
		{
			case Color.Red:
				Console.WriteLine("The color is red");
				break;
			case Color.Green:
				Console.WriteLine("The color is green");
				break;
			case Color.Blue:
				Console.WriteLine("The color is blue");
				break;
			default:
				Console.WriteLine("The color is unknown.");
				break;
		}
	}
}