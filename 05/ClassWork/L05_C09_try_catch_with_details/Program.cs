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
		catch (Exception e)
		{
			Console.WriteLine("Can't continue calculation:");
			Console.WriteLine($"{e.GetType()}: {e.Message}");
		}

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}