using System;

namespace L09_C06_ref_parameters
{
	class Person
	{
		public string Name { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			int a = 0;
			Increment(ref a);
			Console.WriteLine(nameof(a) + " = " + a);

			string t = "test";
			AddSuffix(ref t);
			Console.WriteLine(nameof(t) + " = " + t);

			Person p = new Person
			{
				Name = "Andrei"
			};
			AddSuffix(ref p);
			Console.WriteLine(" p.Name = " + p.Name);
		}

	 

		static void Increment(ref int val)
		{
			val++;
			Console.WriteLine(nameof(val) + " = " + val);
		}

		static void AddSuffix(ref string message)
		{
			message = message + " (suffix)";
			Console.WriteLine(nameof(message) + " = " + message);
		}

		static void AddSuffix(ref Person person)
		{
			person = new Person();
			person.Name = person.Name + " (suffix)";
		}
	}
}
