using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter 5 integer values:");
		int[] numbers = new int[5];

		for (int i = 0; i < 5; i++)
		{
			var num = int.Parse(Console.ReadLine());
			numbers[i] = num;
		}

		Console.WriteLine("The entered values are: " + string.Join(", ", numbers));

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}