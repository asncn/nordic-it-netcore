using System;

namespace L15_C10_delegate_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			Func <double, double> perimeter = radius =>  (2 * Math.PI* radius);
			//Func<double, double> square = radius => (Math.PI * Math.Pow(radius, 2));

			const double circleRadius = 1.5;
			var circle = new Circle(circleRadius);

			var circlePerimeter =
				circle.Calculate(perimeter);

			var circleSquare =
				circle.Calculate(radius => (Math.PI * Math.Pow(radius, 2)));

			Console.WriteLine(
				$"For the circle with radius {circleRadius}\n" +
				$"\tPerimeter is\t{circlePerimeter}\n" +
				$"\tSquare is\t{circleSquare}");
		}
	}
}
