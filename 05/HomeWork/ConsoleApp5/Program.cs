using System;


class Program
{

    static void Main(string[] args)

    {
        Console.Write("Введите тип фигуры (1 - круг, 2 - равносторонний треугольник, 3 - прямоугольник): ");
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
            Console.WriteLine("Ошибка! Введено нечисловое значение!");
            throw;
        }

        if (parameter < 1 || parameter > 3)
        {
            throw new Exception("Введенное значение выходит за допустимые пределы от 1 до 3!");
        }

        string message = string.Empty;

        switch (parameter)
        {
            case 1:
                message = "Введите диаметр круга";
                Console.WriteLine(message);

                string a = Console.ReadLine();

                try
                {
                    parameter = int.Parse(a);
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                    throw;
                }

                parameter = int.Parse(a);

                resultS = (Math.PI * (parameter * parameter)) / 4;
                resultP = Math.PI * parameter;
                Console.WriteLine($"Площадь поверхности: " + Math.Round(resultS, 0));
                Console.WriteLine($"Длина периметра: " + Math.Round(resultP, 0));
                break;

            case 2:
                message = "Введите длину стороны";
                Console.WriteLine(message);

                string b = Console.ReadLine();

                try
                {
                    parameter = int.Parse(b);
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                    throw;
                }

                parameter = int.Parse(b);

                resultS = ((parameter * parameter) * Math.Sqrt(3)) / 4;
                resultP = parameter * parameter * parameter;
                Console.WriteLine($"Площадь поверхности: " + Math.Round(resultS, 0));
                Console.WriteLine($"Длина периметра: " + Math.Round(resultP, 0));
                break;

            case 3:
                message = "Введите длину прямоугольника:";
                Console.WriteLine(message);

                string c = Console.ReadLine();

                try
                {
                    parameter = int.Parse(c);
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                    throw;
                }
                parameter = int.Parse(c);

                message = "Введите высоту прямоугольника:";

                Console.WriteLine(message);

                string d = Console.ReadLine();

                try
                {
                    parameter = int.Parse(d);
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                    throw;
                }

                parameter2 = int.Parse(d);

                resultS = parameter * parameter2;
                resultP = (2 * parameter) + (2 * parameter2);
                Console.WriteLine($"Площадь поверхности: " + Math.Round(resultS, 0));
                Console.WriteLine($"Длина периметра: " + Math.Round(resultP, 0));
                break;

        }

    }
}
