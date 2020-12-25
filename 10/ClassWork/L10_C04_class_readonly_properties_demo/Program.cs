using System;

class Program
{
	static void Main()
	{
		Person p1 = new Person();
		p1.Name = "Andrei";
		p1.Age = 36;

        Console.WriteLine(p1.Age);
	}
}

class Person
{
	
	public int Age
	{
		get { return Age; }
		set
		{
			if (value > 0 && value < 140)
			{
				Age = value;
			}
		}
	}

	public string Name { get; set; }
}
