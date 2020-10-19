using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter 5 integer values to summarize them:");

		int sum = 0;
		int num = 0;    // variable to calculate the number of entered values
		while (num < 5) // checking that number of entered values less than 5
		{
			try
			{
				var i = int.Parse(Console.ReadLine());
				sum = sum + i;
			}
			catch (FormatException)
			{
				Console.WriteLine($"Aborting! only {num} values were summarized!");
				break;
			}
			num++;
		}
		Console.WriteLine($"The sum is {sum}. Press any key to exit...");
		Console.ReadKey();
	}
}