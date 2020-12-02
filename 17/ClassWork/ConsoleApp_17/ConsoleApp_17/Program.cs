using System;
using System.Threading;

namespace ConsoleApp_17
{
    partial class Program
    {

        public delegate void WorkPerformedEventHandler(int hours, WorkType workType);

        static void Main(string[] args)
        {

            var worker = new Worker();
           

            worker.WorkComleted += (sender, e) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("wORK COMPLETED!");
                Console.ResetColor();
            };

            worker.WorkPerformed += (sender, e) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{((Worker)sender) .Name} {e.TypeOfWork} in progress {e.hours} hours");
                Console.ResetColor();
            };

            Thread t1 = new Thread(() => worker.DoWork(8, WorkType.Work));
            Thread t2 = new Thread(() => worker.DoWork(8, WorkType.DoNothing));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
                      

            worker.DoWork(8, WorkType.Work);
            worker.DoWork(2, WorkType.DoNothing);




            //    var del1 = new WorkPerformedEventHandler(WorkPerformed1);
            //    var del2 = new WorkPerformedEventHandler(WorkPerformed2);
            //    var del3 = new WorkPerformedEventHandler(WorkPerformed3);

            //    del1 += del2;
            //    del1 += del3;

            //    int finalResult = del1(1, WorkType.Work);
            //    Console.WriteLine(finalResult);
            //}

            //static int WorkPerformed1(int hours, WorkType worktype)
            //{
            //    Console.WriteLine($"{nameof(WorkPerformed1)} called with ({worktype}, {hours})");
            //    return hours + 1;
            //}
            //static int WorkPerformed2(int hours, WorkType worktype)
            //{
            //    Console.WriteLine($"{nameof(WorkPerformed2)} called with ({worktype}, {hours})");
            //    return hours + 2;
            //}
            //static int WorkPerformed3(int hours, WorkType worktype)
            //{
            //    Console.WriteLine($"{nameof(WorkPerformed3)} called with ({worktype}, {hours})");
            //    return hours + 3;
        }

       
    }
}
