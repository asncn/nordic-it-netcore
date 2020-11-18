using System;

public class Person
{
	public string Name { get; set; }
	public DateTimeOffset DateOfBirth { get; set; }

	public virtual string ShortDescription
	{
		get
		{
			return $"{GetType().Name} " +
				   $"name: {Name}, " +
				   $"date of birth: {DateOfBirth:dd-MM-yy}";
		}
	}

	public void WriteShortDecription()
	{
		Console.WriteLine(ShortDescription);
	}
}
