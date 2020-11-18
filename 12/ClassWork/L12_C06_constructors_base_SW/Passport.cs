using System;

public class Passport : BaseDocument
{
	public string Country { get; set; }

	public string PersonName { get; set; }

	public Passport(
		string docNumber,
		DateTimeOffset issueDate)
		: base("Passport", docNumber, issueDate)
	{
	}

	public Passport(
		string docNumber,
		DateTimeOffset issueDate,
		string personName)
		: this(docNumber, issueDate)
	{
		PersonName = personName;
	}

	public Passport(
	  string docNumber,
	  DateTimeOffset issueDate,
	  string country,
	  string personName) : this(docNumber, issueDate, personName)
	{
		Country = country;
	}

	public override string PropertiesString
	{
		get
		{
			if(Country == null && PersonName == null)
			{
				return base.PropertiesString;
			}

			return $"{DocName} #{DocNumber} issued "
				   + $"{IssueDate:dd-MM-yy} in "
				   + $"{Country} for {PersonName}";
		}
	}
}
