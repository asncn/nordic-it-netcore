using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter integer values.");
		Console.WriteLine("When Sum exceeds 100 program will be finished:");

		int sum = 0;
		do
		{
			try
			{
				var i = int.Parse(Console.ReadLine());
				sum = sum + i;
			}
			catch (FormatException)
			{
				Console.WriteLine("You entered wrong value! Calculation is finished.");
				break;
			}
		} while (sum < 100);

		Console.WriteLine($"The sum is {sum}. Press any key to exit...");
		Console.ReadKey();
	}
}