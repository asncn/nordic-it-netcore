using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter the string for encryption: ");
		int encrypctionKey = 1;
		string line = Console.ReadLine();

		foreach (char letter in line)
		{
			Console.Write((char)(letter + encrypctionKey));
		}

		Console.WriteLine();

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}