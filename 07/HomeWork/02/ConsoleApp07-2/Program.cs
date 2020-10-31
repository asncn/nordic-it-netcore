using System;
using System.Text;

namespace Homework_2_of7th_lesson
{
	class Program
	{
		static void Main(string[] args)
		{
			string textInput;
			Console.WriteLine("Введите текст: ");
			do
			{
				textInput  = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(textInput))
				{
					Console.WriteLine("Вы ввели пустую строку! Попробуйте ещё раз: ");
					continue;
				}
				StringBuilder lineNew = new StringBuilder(textInput.Length);
				int i = 0;

				for (; i < lineNew.Capacity; i++)
					lineNew.Insert(0, textInput[i]);
			
				Console.WriteLine(lineNew.ToString().ToLower());

			} while (string.IsNullOrWhiteSpace(textInput));
		}
	}
}