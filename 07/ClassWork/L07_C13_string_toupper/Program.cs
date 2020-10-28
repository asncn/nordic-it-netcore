using System;

class Program
{
	static void Main()
	{
		Console.Write("Enter cardholder name: ");
		string cardholder = Console.ReadLine();

		Console.WriteLine($"Valid cardholder name: {cardholder.ToUpper()}");

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}