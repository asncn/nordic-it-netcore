using System;
using System.Text;

namespace L07_C11_string_search_SW
{
	class Program
	{
		/* 
		 * Optional in-class practice work.
		 * 
		 * Program Description
		 * 1. Request two lines
		 * 1.a. The first one is the source to search in
		 * 1.b. The second line the substring that we will search for"
		 * 2. Found all the indexes of substrings found in the source string.
		 * 3. Write out found indexes or hyphen sign (-) in case of substring was not found.
		 */

		static void Main(string[] args)
		{
			Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

			Console.WriteLine("Enter the source string to search in:");
			var source = Console.ReadLine();

			Console.WriteLine("Enter the string to search for:");
			var substring = Console.ReadLine();

			int gavno = -1;
			string answer = string.Empty;
			do
			{
				gavno = source.IndexOf(substring, gavno + 1);

				if (gavno >= 0)
				{
					answer += gavno + " ";
				}
			}
			while (gavno >= 0);

			Console.WriteLine(answer == string.Empty
				? "-"
				: answer);
		}
	}
}
