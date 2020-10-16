using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter a number less than 100:");
		string strNum = Console.ReadLine();
		int num = int.Parse(strNum);

		if (num >= 100)
		{
			throw new Exception("The value should be less than 100!");
		}

		Console.WriteLine($"You entered correct value {num}");
		Console.ReadKey();
	}
}