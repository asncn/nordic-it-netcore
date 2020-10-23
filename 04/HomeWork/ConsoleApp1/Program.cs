using System;
using System.Globalization;

namespace _4th_Homework
{
    class Program
    {

        static void Main(string[] args)
        {
            int Small = 1;
            int Medium = 5;
            int Large = 20;

            int firstContainer = 0;
            int secondContainer = 0;
            int thirdContainer = 0;

            string delimiter =

                CultureInfo
                .CurrentCulture
                .NumberFormat
                .NumberDecimalSeparator;

            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать? " +
                $"Введите число, используя '{delimiter}' ,если оно не целое");

            string InputNumber = Console.ReadLine();

            double Number = double.Parse(InputNumber);

            Console.WriteLine("Вам потребуются следующие контейнеры:");
            for (thirdContainer = 0; Large <= Number; thirdContainer++)
            {
                Number = Math.Ceiling(Number - Large);
            }

            if (thirdContainer != 0)
            {
                Console.WriteLine($"20л: " + thirdContainer + "шт.");
            }

            for (secondContainer = 0; Medium <= Number; secondContainer++)
            {
                Number = Math.Ceiling(Number - Medium);
            }

            if (secondContainer != 0)
            {
                Console.WriteLine($"5л: " + secondContainer + "шт.");
            }

            for (firstContainer = 0; Small <= Number; firstContainer++)
            {
                Number = Math.Ceiling(Number - Small);
            }

            if (firstContainer != 0)
            {
                Console.WriteLine($"1л: " + firstContainer + "шт.");
            }
        }
    }
}


