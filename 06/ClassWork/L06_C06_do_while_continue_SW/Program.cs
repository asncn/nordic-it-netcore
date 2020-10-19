using System;

class Program
{
	static void Main()
	{
		string str;
		Console.WriteLine("Enter text string (or \"exit\" to finish):");
		do
		{
			str = Console.ReadLine();

			if (str == "exit")
				break;

			if (str.Length > 15)
			{
				Console.WriteLine($"Too long string. Try another:");
				continue;
			}

			Console.WriteLine($"Entered string length is {str.Length}.");

			// As an option we can use operator ?: which is better readable
			// but in that case will not be able to demonstrate 
			// the power of operator "continue"
			//
			//Console.WriteLine(
			//	str.Length > 15
			//		? $"Too long string. Try another:"
			//		: $"Entered string length is {str.Length}.");
		} while (true);

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}
