using System;

namespace L12_C00_constructors
{

	public class Employee : Person
	{
		public string EmployeeCode { get; set; }

		public DateTimeOffset HireDate { get; set; }
		
		public new string ShortDescription
		{
			get { return $"{Name}: {DateOfBirth}, {EmployeeCode} // {HireDate}"; }
		}

		public new void WriteShortDescription()
		{
			Console.WriteLine(ShortDescription);
		}
	}
}