using System;

class Program
{
	static void Main()
	{
		var test = "my test string";

		// split strings into string array
		string[] words = test.Split(' ');

		// rebuild string taking the first and the third words only
		string result = string.Join("_", words[0], words[2]);

		Console.WriteLine(result);
		// my_string
	}
}
