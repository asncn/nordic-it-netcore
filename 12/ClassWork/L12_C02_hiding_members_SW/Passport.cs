using System;

public class Passport : BaseDocument
{
	public string Country { get; set; }

	public string PersonName { get; set; }

	new public string PropertiesString
	{
		get
		{
			return $"{DocName} #{DocNumber} issued "
				   + $"{IssueDate:dd-MM-yy} in "
				   + $"{Country} for {PersonName}";
		}
	}

	public Passport(
		string docNumber,
		DateTimeOffset issueDate,
		string country,
		string personName)
	:base("Passport", docNumber, issueDate)
	{
		Country = country;
		PersonName = personName;
	}

	new public void WriteToConsole()
	{
		Console.WriteLine(PropertiesString);
	}
}
