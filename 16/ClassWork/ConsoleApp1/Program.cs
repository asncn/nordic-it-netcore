using System;
using RectangleUtility;

namespace RectangleDemoApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var rect1 = new Rectangle<short>(short.MaxValue, 7000);
			short square = rect1.Calculate(
				(short x, short y) => checked((short)(x * y)));


			Console.WriteLine(square);
			Console.ReadLine();
		}
	}
}
