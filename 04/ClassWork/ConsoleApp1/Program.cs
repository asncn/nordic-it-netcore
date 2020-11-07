using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Please enter some word or exit by typing 'Exit'");

			////do
			////{ // begin of the cycling block
			////	input = Console.ReadLine();

			////} while (input != "Exit"); // end of block, check the condition

			//string input;
			//do
			//{
			//	input = Console.ReadLine();


			//	if (input == "Exit")
			//		break;

			//	if (input.Length <= 15)
			//	{
			//		Console.WriteLine($"Entered string length is {input.Length}");
			//	}
			//	else
			//	{
			//		Console.WriteLine("Too long string. Try another");
			//	}


			//} while (true);

			//int[] numbers = {300, 222, 1};
			//int sum = 0;
			//int i = 0;


			//while (i < numbers.Length)
			//   {

			//	sum = sum + numbers[i];
			//	Console.WriteLine("Current sum: " + sum);

			//	i++;

			//   }

			//Console.WriteLine("Total sum: " + sum);


			//int[] numbers = { 300, 222, 1 };
			//int sum2 = 0;
			//int sum3 = 0;

			//for (int j = 0; j < numbers.Length; j++)
			//{
			//	if (numbers[j] > 0)
			//	{
			//		sum2 = sum2 + numbers[j];
			//		Console.WriteLine("Current sum: " + sum2);
			//	}
			//	else
			//	{
			//		sum3 = sum3 + numbers[j];
			//		Console.WriteLine("Current sum: " + sum3);

			//	}

			//}

			//Console.WriteLine("Sum positive: " + sum2);
			//Console.WriteLine("Sum negative: " + sum3);



			var marks = new[]
           {
            new [] { 2, 3, 3, 2, 3}, // Monday (it was a good weekend :)
            new [] { 2, 4, 5, 3}, // Tuesday (anyway better than Monday)
            null, // Wednesday (felt sick, stayed at home :( )
            new [] { 5, 5, 5, 5}, // Thursday (God mode :)
            new [] { 4 } // Friday (a very short day)
           };			int totalSum = 0;			for (int i = 0; i < marks.Length; i++)
			{
				int marksNumber = marks[i].Length;

				int daySum = 0;

				if (marks[i] == null)
					Console.WriteLine("not applicable");
				continue;

				for (int j = 0; j < marksNumber; i++)
				{
					daySum += marks[i][j];

				}

				float dayAverage = (float)daySum / marksNumber;
				Console.WriteLine($"The average mark for day #   {i} is {dayAverage}");


				

				//int sumOfDay;

				//for (int j = 0; j < marks[i].Length; j++ )
				//{ 
				//	sumOfDay += marks[i][j];
				//	sum += marks[i][j];

				//    Console.WriteLine(sumOfDay);
				//}

			}
			





			Console.ReadKey();
		}
	}
}
