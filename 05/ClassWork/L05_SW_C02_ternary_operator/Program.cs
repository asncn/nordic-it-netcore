using System;

namespace L05_SW_C02_ternary_operator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число от 1 до 100: ");
			int number = int.Parse(Console.ReadLine());

			Console.WriteLine(number < 50
				? "Введенное число меньше 50"
				: "Введенное число больше либо равно 50");
		}
	}
}
