using System;

class Program
{
	static void Main()
	{
		Console.WriteLine(string.IsNullOrWhiteSpace("   \t   "));	// true
		Console.WriteLine(string.IsNullOrEmpty(""));				// true
		Console.WriteLine(string.IsNullOrEmpty(null));				// true
	}
}