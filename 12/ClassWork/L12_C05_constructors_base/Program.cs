using System;

// Program.cs

internal class Program
{
	private static void Main()
	{
		Person p1 = new Person("Andrei", DateTimeOffset.Parse("1982-03-14"));
		p1.WriteShortDecription(); // Person name: Andrei, date of birth: 14-03-82

		Employee e1 = new Employee(
		  "Andrei",
		  DateTimeOffset.Parse("1982-03-14"),
		  "000001",
		  DateTimeOffset.Parse("2016-10-01"));

		e1.WriteShortDecription();
		// Employee code: 000001, name: Andrei,
		// date of birth: 14-03-82, hire date: 01-10-16
	}
}
