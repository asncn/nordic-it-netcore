﻿using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter integer values.");
		Console.WriteLine("When Sum exceeds 100 program will be finished:");

		int sum = 0;
		while (sum < 100)   // now condition checks before the cycling
		{
			try
			{
				var i = int.Parse(Console.ReadLine());
				sum = sum + i;
			}
			catch (FormatException)
			{
				Console.WriteLine("You entered wrong value! Please try again:");
				continue;   // return to the beginning of the cycle!
			}
		}

		Console.WriteLine($"The sum is {sum}. Press any key to exit...");
		Console.ReadKey();
	}
}