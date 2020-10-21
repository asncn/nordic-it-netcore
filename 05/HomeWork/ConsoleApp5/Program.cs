﻿using System;


class Program
{

    static void Main(string[] args)

    {
        Console.Write(" Введите положительное натуральное число не более 2 миллиардов: ");
        string inputString = Console.ReadLine();
        int parameter;
        int parameter2;
        double resultS;
        double resultP;



        try
        {
            parameter = int.Parse(inputString);
        }
        catch
        {
            Console.WriteLine("Ошибка System.FormatException! Попробуйте ещё раз: ");
            throw;
        }

        if (parameter < 1)
        {
            throw new Exception("Введено неверное значение! Попробуйте ещё раз:  ");
        }

        if (parameter > 2000000000)
        {
            throw new Exception("Ошибка System.OverflowException! Попробуйте ещё раз: ");
        }


        foreach (char digitSymbol in parameter.ToString())
        {

            int digit = int.Parse(digitSymbol.ToString());
            Console.WriteLine(digit * digit);
        }


    }

}

