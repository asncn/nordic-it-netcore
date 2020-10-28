using System;
using System.Collections.Generic;
using System.Transactions;

class Program
{
	static void Main()
	{
		Console.WriteLine("������� ������� �������� ��� '����' ��� ������ ��������");
		List<double> numbers = new List<double>();

		// input
		do
		{
			string input = Console.ReadLine();
			if (input.Equals(
				"����",
				StringComparison.CurrentCultureIgnoreCase))
			{
				if (numbers.Count > 1)
					break;

				Console.WriteLine("�� ������ ������ ���� �� ��� �����");
				continue;
			}

			if (!double.TryParse(input, out double number))
			{
				Console.WriteLine("�� ������ ������� ������ ������� ����� ��� '����'");
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
			"�������� ������ ��������:\n" +
			string.Join(", ", numbers));

		Console.WriteLine($"C���� = {sum:0.0##}, ������� �������������� = {average:0.0##}");

	}
}