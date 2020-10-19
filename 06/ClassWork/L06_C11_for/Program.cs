using System;

class Program
{
	static void Main()
	{
		// Common structure
		// for (initializer; condition; iterator)
		//    cycle_body

		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine(i);
		}

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();

		// Output:
		// 0
		// 1
		// 2
		// 3
		// 4
	}
}