 using System;

class Program
{
	static void Main()
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

		// Iterating through the days
		for (int dayIndex = 0; dayIndex < marks.Length; dayIndex++)
		{
			if (marks[dayIndex] == null)
			{
				Console.WriteLine($"The average mark for day {dayIndex} is N/A");
				continue;
			}

			// Iterating through the marks during that day
			int dailySum = 0;
			for (int markIndex = 0; markIndex < marks[dayIndex].Length; markIndex++)
			{
				dailySum += marks[dayIndex][markIndex];
			}

			Console.WriteLine("The average mark for day {0} is {1:0.0}",
				dayIndex,
				(float)dailySum / marks[dayIndex].Length);

			totalSum += dailySum;
			numberOfMarks += marks[dayIndex].Length;
		}

		Console.WriteLine("The average mark for all the week is {0:0.0}",
			(float)totalSum / numberOfMarks);

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}
