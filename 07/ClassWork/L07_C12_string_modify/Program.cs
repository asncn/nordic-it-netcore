using System;

class Program
{
	static void Main()
	{
		var test = "my test string";
		Console.WriteLine(test.Replace("test", "best"));	// my best string
		Console.WriteLine(test.Substring(5, 10));			// str

		string[] words = test.Split(' ');
		foreach (string word in words)
			Console.WriteLine(word);
		// my
		// test
		// string
	}
}