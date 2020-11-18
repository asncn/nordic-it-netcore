using System;

public class BaseDocument
{
	public string DocName { get; set; }

	public string DocNumber { get; set; }

	public DateTimeOffset IssueDate { get; set; }

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
