using System;

class Program
{
	static void Main()
	{
		// Восьмибайтовое дробное число(точность ~15 - 17 знаков после запятой)
		// System.Double или ключевое слово double(±5.0×10 ^−324 – ±1.7×10 ^ 308)

		

		// Output: 3

		// Mixing types in expressions
		
		//float y = 24.002000000F;
		
		
		//Type type = (x + y + z).GetType();
		///Console.WriteLine(type.ToString());
		// Result of the 2nd argument is a double:
		Console.WriteLine((-1 - 999999999999999999).GetType().ToString());

		// Output: The sum is 1712.5
	}

    //private static object GetType(int v, float S, short N, double Y)
    //{
    //    throw new NotImplementedException();
    //}
}
