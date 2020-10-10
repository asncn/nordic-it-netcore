using System;
using System.Globalization;

namespace ConsoleApp
{
	class Program
	{
		//enum DayTime
		//{
		//	Night,
		//	Morning,
		//	Noon,
		//	Evening
		//}

		[Flags]

		enum CarType : byte
		{

			None = 0,
			SUV = 1,
			Sedan = 2,
			Truck = 4,
					   
		}





		static void Main(string[] args)
		{
			var myCarType = CarType.Sedan;

			WriteByteValueWithBits((byte)myCarType);

			CarType supportedCars =
				  CarType.SUV
				| CarType.Sedan
				| CarType.Truck;


		
			WriteByteValueWithBits((byte)supportedCars);

			Console.ReadKey();



			//var currentDayTime = DayTime.Noon;
			//Console.WriteLine(currentDayTime);
			//Console.ReadKey();

			//var currentDayTime =Enum.Parse(typeof(DayTime),Console.ReadLine());

			//Console.WriteLine((DayTime)((int) currentDayTime + 1));
			//Console.ReadKey();



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

			/*double a = 1;
			double h = 2.5;
			int n = 6;
			double j = 2 * Math.Tan(Math.PI / n);

			//Console.WriteLine("Type a,h and n!");
			double Sp = ((n * a) / 2) * ((a / j) + Math.Sqrt((h * h) + ((a / j) * (a / j))));

			double Sb = ((n * a) / 2) * (Math.Sqrt((h * h) + ((a / j) * (a / j))));

			double V = (h * n * a * a) / (12 * Math.Tan((Math.PI) / n));

			Console.WriteLine(Sp);
			Console.WriteLine(Sb);
			Console.WriteLine(V);
			Console.ReadKey(); */

			//string delimiter = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

			//Console.WriteLine($"Enter floating number," +
			//	$"use '{delimiter}' as number decimal separator:");

			//string strFloat = Console.ReadLine();

			//float f = Single.Parse(strFloat);

			//Console.WriteLine(f * 2); 


			//Console.ReadKey();


		}

		static void WriteByteValueWithBits(byte value)
		{
			Console.WriteLine(
				"0x{0}\t({1})\t{2}",
				value.ToString("X").PadLeft(2, '0'),
				Convert.ToString(value, 2).PadLeft(8, '0'),
				value.ToString().PadLeft(3, '0'));
		}
	}
}
