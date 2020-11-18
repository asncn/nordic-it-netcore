using System;

internal class Program
{
	private static void Main(string[] args)
	{
		var documents = new BaseDocument[2];

		documents[0] = new BaseDocument(
		  "Drive License",
		  "AB32DS32",
		  DateTimeOffset.Parse("2012-02-03"));

		documents[1] = new Passport(
		  "32135432",
		  DateTimeOffset.Parse("2012-02-03"),
		  "Andrei Golyakov",
		  "Russia");

		foreach (var document in documents)
		{
			if (document is Passport)
			{
				((Passport)document).ChangeIssueDate(DateTimeOffset.UtcNow);
			}

			document.WriteToConsole();
		}
	}
}
