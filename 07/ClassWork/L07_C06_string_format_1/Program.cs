using System;

class Program
{
	static void Main()
	{
		double i = 15;
		double j = Math.PI;
		string s = string.Format(
			"{0:000.###} divided by {1:000.###} equals to {2:000.###}", 
			i,
			j,
			i / j);
		Console.WriteLine(s);
	}
}