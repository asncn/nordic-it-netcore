using System;

public class Passport : BaseDocument
{
	public string Country { get; set; }

	public string PersonName { get; set; }

	public Passport(
	  string docNumber,
	  DateTimeOffset issueDate,
	  string country,
	  string personName) : base("Passport", docNumber, issueDate)
	{
		Country = country;
		PersonName = personName;
	}

	public override string PropertiesString
	{
		get
		{
			return $"{DocName} #{DocNumber} issued "
				   + $"{IssueDate:dd-MM-yy} in "
				   + $"{Country} for {PersonName}";
		}
	}

	public void ChangeIssueDate(DateTimeOffset newIssueDate)
	{
		IssueDate = newIssueDate;
	}
}
