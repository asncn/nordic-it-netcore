using System;
using System.Threading;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Write your name!");
			string name = Console.ReadLine();
			Thread.Sleep(5000);
			Console.WriteLine($"Hello, {name}!");
			Console.ReadKey();
		}
	}
}
