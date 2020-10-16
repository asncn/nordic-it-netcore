using System;

class Program
{
	static void Main()
	{
		// for example, we would like to create a simple calculator
		Console.WriteLine("Enter integer value A: ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter integer value B: ");
		int b = int.Parse(Console.ReadLine());

		int result = a / b;

		Console.WriteLine($"{a} divide by {b} equals to {result}");
		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}