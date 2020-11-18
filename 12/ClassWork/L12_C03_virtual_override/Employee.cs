using System;

public class Employee : Person
{
	public string EmployeeCode { get; set; }

	public DateTimeOffset HireDate { get; set; }

	public override string ShortDescription
	{
		get
		{
			return $"{GetType().Name} " +
			       $"code: {EmployeeCode}, " +
			       $"name: {Name}, " +
			       $"date of birth: {DateOfBirth:dd-MM-yy}," +
			       $"hire date: {HireDate:dd-MM-yy},";
		}
	}

	//public void WriteShortDecription()
	//{
	//  Console.WriteLine(ShortDescription);
	//}
}
