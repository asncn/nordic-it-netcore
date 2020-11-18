using System;

namespace L12_C10_BaseDerivedDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			object[] array = new object[4];
			array[0] = 5;
			array[1] = true;
			array[2] = new Square { SideA = 5 };
			array[3] = new Rectangle { SideA = 7, SideB = 10 };

			Presenter p = new Presenter();

			foreach (var o in array)
			{	
				p.WriteToConsole(o);
			}
		}
	}
}
