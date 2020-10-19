using System;

namespace L06_C16_foreach_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			// Weekly school marks
			var marks = new[]
			{
				new [] { 2, 3, 3, 2, 3 }, // Monday (it was a good weekend :)
				new [] { 2, 4, 5, 3 },    // Tuesday (anyway better than Monday)
				null,                     // Wednesday (felt sick, stayed at home :( )
				new [] { 5, 5, 5, 5 },    // Thursday (God mode :)
				new [] { 4 }              // Friday (a very short day)
			};

			// Overall average mark by the week
			int totalSum = 0;

			// Overall number of marks by the week
			int numberOfMarks = 0;

			int dayIndex = 0;
			// Iterating through the days
			foreach (int[] dailyMarks in marks)
			{
				if (dailyMarks == null)
				{
					Console.WriteLine($"The average mark for day {dayIndex} is N/A");
					continue;
				}

				// Iterating through the marks during that day
				int dailySum = 0;
				foreach (int mark in dailyMarks)
				{
					dailySum += mark;
				}

				Console.WriteLine("The average mark for day {0} mark {1:0.0}",
					dayIndex,
					(float)dailySum / dailyMarks.Length);

				totalSum += dailySum;
				numberOfMarks += dailyMarks.Length;
				dayIndex++;
			}

			Console.WriteLine("The average mark for all the week is {0:0.0}",
				(float)totalSum / numberOfMarks);

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
