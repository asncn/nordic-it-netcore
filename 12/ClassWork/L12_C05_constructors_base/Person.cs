using System;
using System.Diagnostics;

public class Person
{
	public string Name { get; set; }

	public DateTimeOffset DateOfBirth { get; set; }

	public Person(string name, DateTimeOffset dateOfBirth)
	{
		Name = name;
		DateOfBirth = dateOfBirth;
		Debug.WriteLine("Constructor Person(name, dateOfBirth) called");
	}

	public Person()
	{
		
	}

	public Person(string name)
	{
		Name = name;
		Debug.WriteLine("Constructor Person(name) called");
	}

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
