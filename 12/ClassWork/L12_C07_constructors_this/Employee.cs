using System;
using System.Diagnostics;

public class Employee : Person
{
  public string EmployeeCode { get; set; }

  public DateTimeOffset HireDate { get; set; }

  public Employee(string name, DateTimeOffset dateOfBirth)
    : base(name, dateOfBirth)
  {
    Debug.WriteLine("Constructor Employee(name, dateOfBirth) called");
  }

  public Employee(
    string name,
    DateTimeOffset dateOfBirth,
    string employeeCode,
    DateTimeOffset hireDate)
    : this(name, dateOfBirth)
  {
    Debug.WriteLine("Constructor Employee(name, dateOfBirth, employeeCode, hireDate) called");
    EmployeeCode = employeeCode;
    HireDate = hireDate;
  }

  public override string ShortDescription
  {
    get
    {
      return $"{GetType().Name} " +
             $"code: {EmployeeCode}, " +
             $"name: {Name}, " +
             $"date of birth: {DateOfBirth:dd-MM-yy}, " + 
             $"hire date: {HireDate:dd-MM-yy}";
    }
  }
}