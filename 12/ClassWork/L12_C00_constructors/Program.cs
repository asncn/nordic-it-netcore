using System;

namespace L12_C00_constructors
{
	class Program
	{
		static void Main(string[] args)
		{
			Figure triangle = new Figure("Triangle");
			string s = triangle.FigureType;

			Figure rectangle = new Figure("Rectangle");
		}
	}
}
