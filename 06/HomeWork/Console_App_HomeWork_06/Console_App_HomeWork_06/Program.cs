using System;


class Program
{

    static void Main(string[] args)

    {
        Console.Write(" Введите положительное натуральное число не более 2 миллиардов: ");
        string inputString = Console.ReadLine();
        int inputNumber;

        try
        {
            inputNumber = int.Parse(inputString);
        }
        catch
        {
            Console.WriteLine("Ошибка System.FormatException! Попробуйте ещё раз: ");
            throw;
        }

        if (inputNumber < 1)
        {
            throw new Exception("Введено неверное значение! Попробуйте ещё раз:  ");
        }

        if (inputNumber > 2000000000)
        {
            throw new Exception("Ошибка System.OverflowException! Попробуйте ещё раз: ");
        }

        int Length = 0;
        foreach (char digitSymbol in inputNumber.ToString())
        {

            int digit = int.Parse(digitSymbol.ToString());

            if (digit % 2 == 0)
            {
                Length++;
            }

        }
        Console.WriteLine($"В числе {inputNumber} содержится следующее количество четных цифр: {Length}");

    }

}