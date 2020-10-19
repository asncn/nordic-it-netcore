using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter integer values.");
		Console.WriteLine("When Sum exceeds 100 program will be finished:");

		int sum = 0;

		do
		{   // begin of the cycling block
			int i = int.Parse(Console.ReadLine());
			sum = sum + i;
		} while (sum < 100);

		Console.WriteLine($"The sum is {sum}. Press any key to exit...");
		Console.ReadKey();
	}
}
