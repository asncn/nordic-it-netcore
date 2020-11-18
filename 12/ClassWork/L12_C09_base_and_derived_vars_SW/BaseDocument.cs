using System;

public class BaseDocument
{
	public string DocName { get; set; }

	public string DocNumber { get; set; }

	public DateTimeOffset IssueDate { get; set; }


	public BaseDocument(string docName, string docNumber, DateTimeOffset issueDate)
	{
		DocName = docName;
		DocNumber = docNumber;
		IssueDate = issueDate;
	}

	public virtual string PropertiesString
	{
		get
		{
			return $"{DocName} #{DocNumber} issued {IssueDate:dd-MM-yy}";
		}
	}

	public void WriteToConsole()
	{
		Console.WriteLine(PropertiesString);
	}
}
