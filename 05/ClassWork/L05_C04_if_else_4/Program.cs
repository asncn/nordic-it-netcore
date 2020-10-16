using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter a number less than 1000:");
		string strNum = Console.ReadLine();
		int num = int.Parse(strNum);
		string message;

		if (num < 100)
		{
			message = "Correct number!";
		}
		else if (num >= 100 && num < 1000)
		{
			message = "Correct but very big number!";
		}
		else
		{
			message = "Error!";
		}

		Console.WriteLine(message + " Press any key to exit...");
		Console.ReadKey();
	}
}