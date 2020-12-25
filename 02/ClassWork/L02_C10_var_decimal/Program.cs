using System;

class Program
{
	static void Main()
	{
		// 16-байтное дробное число повышенной точности (~28-29 знаков после запятой)
		// System.Decimal или ключевое слово decimal(±1.0×10 ^ -28 – ±7.9228×10 ^ 28)
		 

		double dec = 10;
		double dub = 9;

		// The following line causes an error that reads "Operator '+' cannot
		// be applied to operands of type 'double' and 'decimal'"
		// Console.WriteLine(dec + dub); // gives compile error!

		// You can fix the error by using explicit casting of either operand.
		Console.WriteLine($"{ (dec + (int)dub)} + 255   = { (dec + (int)dub).ToString() + 255}");
		
	}
}