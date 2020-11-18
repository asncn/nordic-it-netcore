using System;

public class BaseDocument
{
	public string DocName { get; set; }

	public string DocNumber { get; set; }

	public DateTimeOffset IssueDate { get; set; }

	public string PropertiesString
	{
		get
		{
			return $"{DocName} #{DocNumber} issued {IssueDate:dd-MM-yy}";
		}
	}

	public BaseDocument(
		string docName,
		string docNumber,
		DateTimeOffset issueDate)
	{
		DocName = docName;
		DocNumber = docNumber;
		IssueDate = issueDate;
	}

	public void WriteToConsole()
	{
		Console.WriteLine(PropertiesString);
	}
}
