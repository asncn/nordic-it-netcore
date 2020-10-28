using System;

class Program
{
	static void Main()
	{
		double i = 15;
		double j = Math.PI;
		var s = $"{i} divided by {j:#.##} equals to {i / j:#.##}";
		Console.WriteLine(s); // 15 divided by 3.14 equals to 4.77

		DateTime now = DateTime.Now;
		string result = $"Now is {now:dd.MM.yyyy HH:mm}";
		Console.WriteLine(result);
	}
}