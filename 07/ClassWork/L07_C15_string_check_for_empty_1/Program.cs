using System;

class Program
{
	static void Main()
	{
		string cardholder;
		do
		{
			Console.Write("Enter cardholder name: ");
			cardholder = Console.ReadLine();

		} while (string.IsNullOrWhiteSpace(cardholder));

		Console.WriteLine($"Valid cardholder name: {cardholder.ToUpper()}");

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}