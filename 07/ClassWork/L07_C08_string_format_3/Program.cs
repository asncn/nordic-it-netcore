using System;

class Program
{
	static void Main()
	{
		DateTime now = DateTime.Now;
		string result = String.Format("Now is {0:dd.MM.yyyy HH:mm}", now);
		Console.WriteLine(result);
	}
}