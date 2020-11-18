using System;

// Program.cs

internal class Program
{
	private static void Main()
	{
		Person p1 = new Person("Andrei", DateTimeOffset.Parse("1982-03-14"));
		p1.WriteShortDecription(); // Person name: Andrei, date of birth: 14-03-82

		Person e1 = new Employee(
		  "Andrei",
		  DateTimeOffset.Parse("1982-03-14"),
		  "000001",
		  DateTimeOffset.Parse("2016-10-01"));

		e1.WriteShortDecription();
		// Employee code: 000001, name: Andrei,
		// date of birth: 14-03-82, hire date: 01-10-16

		// Two lines below will raise compilator error
		// as Person doesn't know about these fields
		//Console.WriteLine(e1.HireDate);
		//Console.WriteLine(e1.EmployeeCode);

		Console.WriteLine("\n***\nSee experiments with base type:\n***");

		var persons = new Person[3];

		persons[0] = new Person(
		  "Maria", DateTimeOffset.Parse("1987-03-01"));

		persons[1] = new Person(
		  "Sergey", DateTimeOffset.Parse("1981-12-27"));

		persons[2] = new Employee(
		  "Andrei",
		  DateTimeOffset.Parse("1982-03-14"),
		  "000001",
		  DateTimeOffset.Parse("2016-10-01"));

		foreach (var person in persons)
		{
			if (person is Employee)
			{
				var employee = (Employee)person;
				Console.WriteLine(
				  $"{employee.GetType().Name} " +
				  $"code: {employee.EmployeeCode}, " +
				  $"name: {employee.Name}, " +
				  $"date of birth: {employee.DateOfBirth:dd-MM-yy}, " +
				  $"hire date: {employee.HireDate:dd-MM-yy}");
			}
			else
			{
				Console.WriteLine(
				  $"{person.GetType().Name} " +
				  $"name: {person.Name}, " +
				  $"date of birth: {person.DateOfBirth:dd-MM-yy}");
			}
		}
	}
}
