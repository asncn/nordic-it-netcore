using System;
using System.Collections.Generic;
using System.Text;

namespace L12_C00_constructors
{
	public class Person
	{
		public string Name { get; set; }

		public DateTimeOffset DateOfBirth { get; set; }

		public string ShortDescription
		{
			get { return $"{Name}: {DateOfBirth}"; }
		}

		public void WriteShortDescription()
		{
			Console.WriteLine(ShortDescription);
		}
	}
}
