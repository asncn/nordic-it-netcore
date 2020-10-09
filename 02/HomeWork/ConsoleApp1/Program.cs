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

            Console.WriteLine("выберите одно из: +, -, *, :, /, ^n");
            string inputop = Console.ReadLine();
            char inputop1 = char.Parse(inputop);
            if (inputop = '+')
            {
                Console.WriteLine($"Сумма ваших чисел: {number1 + number2 }");
            }
            else if (inputop1 = '-')
            {
                Console.WriteLine($"Разница ваших чисел: {number1 - number2 }");
            }
            else if (Condition3)
            {
                if (inputop1 = ':')
                {
                    Console.WriteLine($"Произведение ваших чисел: {number1 * number2 }");
                }
                else
                {
                    // Condition1, Condition2, and Condition4 are false. Condition3 is true.
                }
            }
            else
            {
                // Condition1, Condition2, and Condition3 are false.
            }
        }
    }
}
