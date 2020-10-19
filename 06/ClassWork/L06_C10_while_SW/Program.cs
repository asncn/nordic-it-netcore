using System;

class Program
{
	static void Main()
	{
		var arr = new[] {7, 43, 23, 32, 34};

		int i = 0;
		int sum = 0;
		while(i < arr.Length)
		{
			sum += arr[i];
			i++;
			Console.WriteLine($"Intermediate sum is {sum}.");
		}

		Console.WriteLine($"The sum is {sum}");

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}
