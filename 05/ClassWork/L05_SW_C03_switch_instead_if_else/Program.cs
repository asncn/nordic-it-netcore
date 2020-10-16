using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Введите длительность договора аренды в годах: ");
		string inputString = Console.ReadLine();

		int numberOfYears = int.Parse(inputString);

		if (numberOfYears < 1 || numberOfYears > 30)
		{
			Console.WriteLine("Вы ввели неверное значение!");
			return;
		}

		string yearsString = string.Empty;

		switch (numberOfYears)
		{
			case 1:
			case 21:
				yearsString = "год";
				break;
			case 2:
			case 3:
			case 4:
			case 22:
			case 23:
			case 24:
				yearsString = "года";
				break;
			default:
				yearsString = "лет";
				break;
		}

		Console.WriteLine(
			"Договор аренды оформлен на период длительностью "
			+ $"{numberOfYears} {yearsString}");
	}
}
