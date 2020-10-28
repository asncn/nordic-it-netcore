using System;

class Program
{
	static void Main()
	{
		var test = " \t my test string \t ";

		Console.WriteLine(test.Trim());
		Console.WriteLine(test.TrimStart());
		Console.WriteLine(test.TrimEnd());

		// my test string		 < no spaces around
		// my test string 	 < spaces at the end
		// 	 my test string	 < spaces at the beginning
	}
}