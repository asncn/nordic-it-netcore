using System;

class Program
{
	static void Main()
	{
		while(true)
		try
		{
			Console.WriteLine("Enter integer value A: ");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter integer value B: ");
			int b = int.Parse(Console.ReadLine());

			int result = a / b;
			Console.WriteLine($"{a} divide by {b} equals to {result}");
		}
		catch (FormatException)			// Cannot parse integer value!
		{
			Console.WriteLine("You entered incorrect data!");
		}
		catch (DivideByZeroException)	// Cannot divide by zero!
		{
			Console.WriteLine("Cannot divide by zero!");
		}

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}