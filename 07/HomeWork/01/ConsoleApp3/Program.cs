using System;
using System.Data.Common;
using System.Linq;

namespace Homework_7th
{
	class Program
	{
		static void Main(string[] args)
		{
			string textInput;
			string[] words;
			char[] charArray;
			Console.WriteLine("Введите строку из нескольких слов: ");
			do
			{
				textInput = Console.ReadLine();
				words = textInput.Split(' ');
				if (words.Length >= 2)
				{
					int lettersCount = 0;
					foreach (string a in words)
					{
						charArray = a.ToCharArray();
						if (charArray[0] == 'a' || charArray[0] == 'A' || charArray[0] == 'а' || charArray[0] == 'А')

						//if (a.Substring(0, 1) == "А" || a.Substring(0, 1) == "а" || a.Substring(0, 1) == "A" ||
							//a.Substring(0, 1) == "a")
						{
							lettersCount++;
						}
					}
					Console.WriteLine($"Количество слов, начинающихся с буквы 'А': {lettersCount}");
				}
				else
				{
					Console.WriteLine("Слишком мало слов! Попробуйте ещё раз: ");
				}
				continue;
			}
			while (words.Length < 2);
		}
	}
}
