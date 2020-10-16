using System;

class Program
{
	static void Main()
	{
		try
		{
			Console.WriteLine("Enter integer value A: ");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter integer value B: ");
			int b = int.Parse(Console.ReadLine());

			int result = a / b;
			Console.WriteLine($"{a} divide by {b} equals to {result}");
		}
		catch (FormatException e)
		{
			var cfg = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Red;

			Console.WriteLine("You entered incorrect data!");
			Console.WriteLine($"{e.GetType()}: {e.Message}");

			Console.ForegroundColor = cfg;
		}

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}