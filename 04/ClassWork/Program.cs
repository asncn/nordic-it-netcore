using System;

namespace ConsoleApp15
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello!");
			//double e = 11 / 3;
			//Console.WriteLine(e);
			//double f = 11.0 / 3;
			//Console.WriteLine(f);
			//Console.ReadKey();

			//int i = 0;
			//int j = ++i;
			//Console.WriteLine(j);
			//Console.ReadKey();


			//bool canSkipOperation = true;
			//if (!canSkipOperation)
			//{
			//	Console.WriteLine("Operation skipped");
			//}

			/*int a = 18;
		    int b = a++;
			Console.WriteLine(a == b);
			Console.WriteLine(a != b);
			Console.WriteLine(a > b);
			Console.WriteLine(a < b);
			Console.WriteLine(a >= b);
			Console.WriteLine(a <= b);

			Console.ReadKey(); */

			//double g = 9.8;
			//int c = (int)g;
			//Console.WriteLine(c);
			//Console.ReadKey();

			//bool isOk = (bool)("true");

			/*long veryBigNumber = long.MaxValue;
			
			int notSoBig = (int)veryBigNumber;

			Console.WriteLine(notSoBig);

			Console.ReadKey(); */

			//double l = 10.5;
			//Console.WriteLine(Convert.ToInt32(l));

			// Console.WriteLine(Math.Round(l, MidpointRounding.ToEven)); //10
			//Console.WriteLine(Math.Round(l, MidpointRounding.AwayFromZero)); // 11
			//Convert.ToByte()
			//Console.ReadKey();

			//float a = 10.5F;
			//float b = 30.21F;

			//float c = MathF.Sqrt(a * a + MathF.Pow(b, 2));
			//Console.WriteLine(c);
			//Console.ReadKey();
			//Math.Tan(Math.PI)

			double a = 1;
			double h = 2.5;
			int n = 6;
			double j = 2 * Math.Tan(Math.PI / n);

			//Console.WriteLine("Type a,h and n!");
			double Sp = ((n * a) / 2) * ( (a / j) +  Math.Sqrt((h * h) + ((a / j) * (a / j))));

			double Sb = ((n * a) / 2) * (Math.Sqrt((h * h) + ((a / j) * (a / j))));

			double V = (h * n * a * a) / 12 * (Math.Tan(Math.PI) / n);

			Console.WriteLine(Sp);
			Console.WriteLine(Sb);
			Console.WriteLine(V);
			Console.ReadKey();




		}
	}
}
