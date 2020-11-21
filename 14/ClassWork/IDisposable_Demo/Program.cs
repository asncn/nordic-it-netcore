using System;

namespace IDisposable_Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			var fw = new FileWriter("test.txt");

			fw.Write("Hello\r\n");
			fw.Write("World\r\n");

			for (int i = 0; i < 10; i++)
				fw.Write(i + " ");

			fw.Close();
		}
	}
}
