using System;

internal class Program
{
	private static void Main(string[] args)
	{
		BaseDocument bd1 = new BaseDocument
		{
			DocName = "Drive License",
			DocNumber = "AB32DS32",
			IssueDate = DateTimeOffset.Parse("2012-02-03")
		};

		bd1.WriteToConsole();

		Passport p1 = new Passport
		{
			DocName = "Passport",
			DocNumber = "32135432",
			IssueDate = DateTimeOffset.Parse("2012-02-03"),
			PersonName = "Andrei Golyakov",
			Country = "Russia"
		};

		p1.WriteToConsole();
	}
}
