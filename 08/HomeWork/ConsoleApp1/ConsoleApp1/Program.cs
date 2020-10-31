using System;
using System.Collections.Generic;

namespace Homework_8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите строку из скобок такого вида: ( ), [ ]: ");
			string input = Console.ReadLine();
			char[] charArray = input.ToCharArray();
			bool result = true;

			Dictionary<char, char> brackets = new Dictionary<char, char>();
			brackets.Add(']', '[');
			brackets.Add(')', '(');
			Stack <char> stack = new Stack <char>();
			foreach (char symbol in charArray)
			{
				if (brackets.ContainsValue(symbol))
				{
					stack.Push(symbol);
				}
				else if (brackets.ContainsKey(symbol))
				{
					if (stack.Count > 0 && stack.Peek() == brackets[symbol])
						stack.Pop();
					else
						result = false;
				}
			}
			if (stack.Count > 0)
				result = false;
			Console.WriteLine(result);
		}
	}
}