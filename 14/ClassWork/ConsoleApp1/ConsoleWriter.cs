using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class ConsoleWriter
	{
		private static ConsoleWriter _instance;

		private ConsoleWriter() { }

		public static ConsoleWriter GetInstance()
		{
			if (_instance == null)
			{
				_instance = new ConsoleWriter();
			}
			return _instance;
		}
	}
}
