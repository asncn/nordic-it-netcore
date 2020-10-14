using System;

using System.Globalization;



namespace _4th_Homework

{

    enum containersType

    {

        Small = 1,
        Medium = 5,
        Large = 20

    }

    class Program

    {

        static void Main(string[] args)

        {

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
            for (thirdContainer = 0; (double)containersType.Large <= Number; thirdContainer++)
            {

                Number = Math.Ceiling(Number - (double)containersType.Large);

            }

            if (thirdContainer != 0)
            {

                Console.WriteLine($"20л: " + thirdContainer + "шт.");

            }

            for (secondContainer = 0; (double)containersType.Medium <= Number; secondContainer++)
            {

                Number = Math.Ceiling(Number - (double)containersType.Medium);

            }

            if (secondContainer != 0)
            {

                Console.WriteLine($"5л: " + secondContainer + "шт.");

            }

            for (firstContainer = 0; (double)containersType.Small <= Number; firstContainer++)
            {

                Number = Math.Ceiling(Number - (double)containersType.Small);

            }

            if (firstContainer != 0)
            {

                Console.WriteLine($"1л: " + firstContainer + "шт.");

            }

        }

    }

}


