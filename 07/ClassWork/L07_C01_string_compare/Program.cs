using System;

class Program
{
	static void Main()
	{
		string a = "test±";
		string b = "T\u0045st\u00b1";

		Console.WriteLine(a);
		Console.WriteLine(b);

		WriteStringCharCodes(a);
		WriteStringCharCodes(b);

		Console.WriteLine(a == b);      // false
		Console.WriteLine(a.Equals(b)); // false
		Console.WriteLine(a.Equals(b, StringComparison.InvariantCultureIgnoreCase)); // true
	}

	public static void WriteStringCharCodes(string input)
	{
		foreach(char letter in input)
			Console.Write((int)letter + " ");
		Console.Write("\n");
	}
}