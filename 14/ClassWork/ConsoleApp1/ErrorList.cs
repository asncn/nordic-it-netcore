using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	//class ErrorList : IDisposable
	//{

	//	public string Category { get; }

	//	public List<string> Errors { get; private set; }

	//	public ErrorList(string category)
	//	{
	//		Errors = new List<string>();
	//		category = Category;
	//	}

	//	public void Dispose()
	//	{
	//		if (Errors != null)
	//		{
	//			Errors.Clear();
	//			Errors = null;
	//		}
	//	}

	//}
	


	public class ErrorList : IEnumerable<string>, IDisposable
	{

		public static string OutputPrefixFormat { get; set; }
		static ErrorList()
		{
			OutputPrefixFormat = "MMMM d, yyyy (h:mm tt)";
		}

		public void WriteToConslole()
		{
			foreach(string error in _errors)
				Console.WriteLine(DateTime.Now.ToString(OutputPrefixFormat) + " " + error);

		}

		public string Category { get; }

		private List<string> _errors;



		public ErrorList(string category)
		{
			_errors = new List<string>();
			category = Category;
		}

		public void Add(string errorMessage)
		{
			_errors.Add(errorMessage);
		}

		public void Dispose()
		{
			if (_errors != null)
			{
				_errors.Clear();
				_errors = null;
			}
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _errors.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _errors.GetEnumerator();
		}
	}

}
