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
		catch // catching ALL exceptions is a bad practice as it may hide problems!
		{
			Console.WriteLine("Can't continue calculation! Something goes wrong!");
		}

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}