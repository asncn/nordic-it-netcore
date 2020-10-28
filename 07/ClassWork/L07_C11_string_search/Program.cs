using System;

class Program
{
	static void Main()
	{
		var test = "test string";
		Console.WriteLine(test.Contains(" "));		// true
		Console.WriteLine(test.StartsWith("te"));	// true
		Console.WriteLine(test.EndsWith("s"));		// false

		Console.WriteLine(test.IndexOf("s"));		// 2
		Console.WriteLine(test.LastIndexOf("s"));	// 5
	}
}