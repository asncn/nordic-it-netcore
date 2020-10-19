using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter text string (or \"exit\" to finish):");

		do
		{
			string str = Console.ReadLine();
			if (str == "exit")
				break;

			// to make break make sense we can add echo below
			// Console.WriteLine($"You entered '{str}'");
		} while (true);

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}
