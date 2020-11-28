using System;

namespace ClassWork_16
{

	delegate int GetNumberFromNumbers(int[] numbers);

	class Program

	{
		static void Main(string[] args)
		{
			var arrayForTests = new[] { 1, 2, 3, 4, 5 };

			GetNumberFromNumbers calculate;

			//calculate = Sum;
			//Console.WriteLine(calculate(arrayForTests));

			//calculate = Average;
			//Console.WriteLine(calculate(arrayForTests));

			WriteNumbersFromNumbers(Sum, arrayForTests);

			WriteNumbersFromNumbers(Average, arrayForTests);

			WriteNumbersFromNumbers((int[] arr) => 
				{
				int result = int.MinValue;
					foreach (var number in arr)
					{
						result = number > result
						? number
						: result;
						//if (number > result)
						//	result = number;
					}
					return result;
				}, 
				arrayForTests);

			Func<int, bool> isNegativeOrZero = x => x <= 0; 



			Console.ReadLine();
		}

		static void WriteNumbersFromNumbers(GetNumberFromNumbers getNumber, int[] arrayForTests)
		{
			Console.WriteLine(getNumber(arrayForTests));
		}

		static int Sum(int[] array)
		{

		int result = 0;

		foreach (var number in array)
			{
				result += number;
			}
			return result;
		}

		static int Average(int[] array)
		{

			int result = 0;

			foreach (var number in array)
			{
				result += number;
			}
			return result / array.Length;
		}
	}
}
