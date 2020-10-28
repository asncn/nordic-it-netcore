using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("c:\\path\\to\\file1.txt");
		Console.WriteLine(@"c:\path\to\file2.txt");

		string multiline = @"Lorem ipsum dolor sit amet, consectetur adipiscing 
elit, sed do eiusmod tempor incididunt ut labore et dolore magna 
aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco 
laboris nisi ut aliquip ex ea commodo consequat.";
		Console.WriteLine(multiline);
	}
}