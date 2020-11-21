using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//using (ErrorList errorList = new ErrorList("Program Error"))
			//{
			//	errorList.Add("11");
			//	errorList.Add("21");

			//	foreach (var item in errorList)
			//	{
			//		Console.WriteLine(item);
			//	}
			//}


			//StaticDemoClass weight1 = new StaticDemoClass();
			//weight1.Weight = 12;

			//StaticDemoClass weight2 = new StaticDemoClass();
			//weight2.Weight = 16;
			//Console.WriteLine(StaticDemoClass.SumWeight);

			//ErrorList list = new ErrorList("category");
			//list.OutputPrefixFormat = "MMMM d, yyyy (h:mm)";

			//System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

			//Console.WriteLine(DateTime.Now.ToString("MMMM d, yyyy (h:mm)"));

			//using (ErrorList errorList = new ErrorList("Program Error"))
			//{
			//	errorList.Add("first");
			//	errorList.Add("second");

			//	errorList.WriteToConslole();
			//}

			ConsoleWriter singleton = ConsoleWriter.GetInstance();
			ConsoleWriter singleton2 = ConsoleWriter.GetInstance();
			Console.WriteLine(singleton2.Equals(singleton));

			Console.ReadLine();
		}
	}
}
