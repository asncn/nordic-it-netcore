using System;
using System.Dynamic;

namespace ConsoleApp07
{
    class Program
    {
        static void Main(string[] args)
        {

            
            char A = 'А';
            int Count = 0;
            string inputString;

            Console.Write("Введите строку: ");
            
            inputString = Console.ReadLine();


            string[] stringMass = inputString.Split(' ');//Массив слов строки
            foreach (var word in stringMass)//Бежим по массиву
                if (word.StartsWith(A))//Проверяем вхождение букв с начало слова
                    Count++;//если входит то +1
            

            
            
            Console.Write(Count);//Вызываем функцию
            Console.ReadKey();
        }
    }
    }

