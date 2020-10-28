using System;

class Program
{
	static void Main()
	{
		double i = 15;
		double j = Math.PI;
		string s = String.Format("{0} divided by {1:#.##} equals to {2:#.##}", i, j, i / j);
		Console.WriteLine(s);
	}
}