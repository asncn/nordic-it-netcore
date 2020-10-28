using System;
using System.Collections.Generic;
using System.Transactions;

class Program
{
	static void Main()
	{
		Console.WriteLine("Введите дробное значение или 'стоп' для начала расчётов");
		List<double> numbers = new List<double>();

		// input
		do
		{
			string input = Console.ReadLine();
			if (input.Equals(
				"стоп",
				StringComparison.CurrentCultureIgnoreCase))
			{
				if (numbers.Count > 1)
					break;

				Console.WriteLine("Вы должны ввести хотя бы два числа");
				continue;
			}

			if (!double.TryParse(input, out double number))
			{
				Console.WriteLine("Вы можете вводить только дробные числа или 'стоп'");
				continue;
			}

			numbers.Add(number);
		} while (true);

		// calculations
		double sum = 0;
		foreach (var number in numbers)
		{
			sum += number;
		}

		double average = sum / numbers.Count;

		numbers.Sort();

		// output
		Console.WriteLine(
			"Итоговый список значений:\n" +
			string.Join(", ", numbers));

		Console.WriteLine($"Cумма = {sum:0.0##}, Среднее арифметическое = {average:0.0##}");

	}
}