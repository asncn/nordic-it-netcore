using System;

internal class Program
{
	private static void Main(string[] args)
	{
		BaseDocument bd1 = new BaseDocument(
			"Drive License",
			"AB32DS32",
			DateTimeOffset.Parse("2012-02-03")
		);

		bd1.WriteToConsole();

		Passport p1 = new Passport(
		
			"32135432",
			DateTimeOffset.Parse("2012-02-03"),
			"Andrei Golyakov",
			"Russia"
		);

		p1.WriteToConsole();

		BaseDocument bd2 = new Passport(
			"342423234",
			DateTimeOffset.Parse("2016-02-03"),
			"Russia",
			"Ivan Petrov"
		);

		bd2.WriteToConsole();
		if (bd2 is Passport)
		{
			((Passport)bd2).WriteToConsole();
		}
	}
}
