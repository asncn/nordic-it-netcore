using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] table1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] table2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ConsoleColor fgcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
                       
            Console.Write("   *");

            for (table1[0] = 1; table1[0] <= table1.Length; table1[0]++)
                Console.Write("{0, 4}", table1[0]);

            Console.ForegroundColor = fgcolor;
            Console.WriteLine();

            for (table1[0] = 1; table1[0] <= table1.Length; table1[0]++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("{0, 4}", table1[0]);

                for (table2[0] = 1; table2[0] <= table2.Length; table2[0]++)
                {
                    Console.ForegroundColor = fgcolor;
                    Console.Write("{0, 4}", table1[0] * table2[0]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
