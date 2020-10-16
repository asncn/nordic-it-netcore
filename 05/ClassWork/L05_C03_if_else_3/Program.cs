using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter a number less than 100:");
		string strNum = Console.ReadLine();
		int num = int.Parse(strNum);
		string message;

		message = num < 100
			? "Correct!"
			: "Error!";

		Console.WriteLine(message + " Press any key to exit...");
		Console.ReadKey();
	}
}
