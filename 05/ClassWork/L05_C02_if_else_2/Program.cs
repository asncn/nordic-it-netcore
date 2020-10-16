using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter a number less than 100:");
		string strNum = Console.ReadLine();
		int num = int.Parse(strNum);
		string message;

		if (num < 100)
		{
			message = "Correct!";
		}
		else
		{
			message = "Error!";
		}

		Console.WriteLine(message + " Press any key to exit...");
		Console.ReadKey();
	}
}