using System;

class Program
{
	static void Main()
	{
		int i = 15;
		int j = 3;
		string result1 = i + " divided by " + j + " equals to " + i / j;
		Console.WriteLine(result1);

		DateTime now = DateTime.Now;
		string result2 = String.Format("Now is {0:dd.MM.yyyy HH:mm}", now);
		Console.WriteLine(result2);
	}
}