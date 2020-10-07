using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите число");
            //string inputNumber1 = Console.ReadLine();
            //object i = int.Parse(inputNumber1);
            //object j = (int)i + 10;
            //Console.WriteLine(Math.Sqrt((int)j));

            //Console.WriteLine("Введите число");
            //object s1 = Console.ReadLine();
            //Console.WriteLine(((string)s1).Length);

            //dynamic s2 = Console.ReadLine();
            //Console.WriteLine(s2.Length);

            //var a = 3.14F;
            //var b = 1D;
            //var c = 49L;
            //var d = (byte)255;
            //Console.WriteLine(a. GetType());
            //Console.WriteLine(b.GetType());
            //Console.WriteLine(c.GetType());
            //Console.WriteLine(d.GetType());

            // int? a = 5;
            // Console.WriteLine(a.Value);

            //Console.WriteLine(a.HasValue);

            //string[] names = new string[2];
            //names[0] = "Andrey";
            //names[1] = "Maria";

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]); // read the item at this index
            //}

            //string[] trees = new string[3];
            ///trees[0] = "Ясень";
            //trees[1] = "Липа";
            //trees[2] = "Кедр";

            //int[] ages = new int[3];
            // ages[0] = 32;
            //ages[1] = 24;
            // ages[2] = 43;

            // for (int i = 0; i < trees.Length; i++)
            //{
            //    Console.WriteLine(trees[i] + " возраст в годах " + ages[i]); // read the item at this index
            //}


            //string[] trees = new string[3];
            //int[] ages = new int[3];

            //for (int i = 0; i < trees.Length; i++)
            //{
            //    Console.WriteLine("Введите имя дерева");
            //    trees[i] = Console.ReadLine();
            //}


            //for (int i = 0; i < trees.Length; i++)
            //{
            //    Console.WriteLine("Введите возраст дерева");
            //    ages[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < trees.Length; i++)
            //{
            //    Console.WriteLine(trees[i] + " - возраст в годах: " + ages[i]); // read the item at this index
            //}
            Console.WriteLine("Type any key");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            Console.WriteLine( $"Key char: {keyInfo.KeyChar}");
            ConsoleModifiers modifiers = keyInfo.Modifiers;


            ConsoleColor fgcolor = Console.ForegroundColor;
            ConsoleColor bgcolor = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(left: 100, top: 10);

            if ((modifiers & ConsoleModifiers.Shift) != 0)
                Console.WriteLine("Shift pressed");

            Console.ForegroundColor = fgcolor;

            if ((modifiers & ConsoleModifiers.Alt) != 0)
                Console.WriteLine("Alt pressed");

            Console.ForegroundColor = fgcolor;

            if ((modifiers & ConsoleModifiers.Control) != 0)
                Console.WriteLine("Control pressed");

            Console.ForegroundColor = fgcolor;
            Console.BackgroundColor = bgcolor;
        }
    }
}
