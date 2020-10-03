using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число");
            string inputNumber1 = Console.ReadLine();
            int number1 = int.Parse(inputNumber1);

            Console.WriteLine("Введите второе число");
            string inputNumber2 = Console.ReadLine();
            int number2 = int.Parse(inputNumber2);
            Console.WriteLine($"Сумма ваших чисел: {number1 + number2 }");
            Console.WriteLine($"Разница ваших чисел: {number1 - number2 }");
            Console.WriteLine($"Произведение ваших чисел: {number1 * number2 }");

        }
    }
}
