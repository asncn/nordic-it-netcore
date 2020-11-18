using System;

internal class Program
{
	private static void Main()
	{
		Person p1 = new Person
		{
			Name = "Andrei",
			DateOfBirth = DateTimeOffset.Parse("1982-03-14")
		};

		p1.WriteShortDecription(); // Person name: Andrei, date of birth: 14-03-82

		Employee e1 = new Employee
		{
			Name = "Andrei",
			DateOfBirth = DateTimeOffset.Parse("1982-03-14"),
			EmployeeCode = "000001",
			HireDate = DateTimeOffset.Parse("2016-10-01")
		};

		e1.WriteShortDecription(); // Employee name: Andrei, date of birth: 14-03-82
	}
}