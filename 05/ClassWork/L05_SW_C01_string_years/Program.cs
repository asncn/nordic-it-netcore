using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Введите длительность договора аренды в годах: ");
		try
		{
			string inputString = Console.ReadLine();
			int numberOfYears = int.Parse(inputString);

			if (numberOfYears < 1 || numberOfYears > 30)
			{
				Console.WriteLine("Вы ввели неверное значение!");
				return;
			}

			string yearsString = string.Empty;

			if (numberOfYears == 1
				|| numberOfYears == 21)
			{
				yearsString = "год";
			}
			else if ((numberOfYears > 1 && numberOfYears < 5)
				|| (numberOfYears > 21 && numberOfYears < 25))
			{
				yearsString = "года";
			}
			else
			{
				yearsString = "лет";
			}
		}
		catch
		{
			Console.WriteLine("fffffffffffffffffffffffffffffffffffffffff");
		}


	}

}
		
	
		

		

