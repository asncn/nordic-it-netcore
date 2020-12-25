using System;
namespace SingletonWork
    
{
    class Program
    {
        static void Main(string[] args)
        {

             //ConsoleLogWriter singleton = ConsoleLogWriter.GetInstance();
             //ConsoleLogWriter singleton2 = ConsoleLogWriter.GetInstance();
           // Console.WriteLine(singleton2.Equals(singleton));

            //MultipleLogWriter singleton = MultipleLogWriter.GetInstance();
           // MultipleLogWriter singleton2 = MultipleLogWriter.GetInstance();
            //Console.WriteLine(singleton2.Equals(singleton));

            ILogWriter consoleWriter = ConsoleLogWriter.GetInstance();
            var fileWriter = new FileLogWriter(@"C:\Git\nordic-it-netcore\13\HomeWork\log.txt");
            //var multipleWriter = new MultipleLogWriter(new ILogWriter[2] { fileWriter, consoleWriter });

            MultipleLogWriter.GetMLWInstance(fileWriter, consoleWriter);

            ILogWriter multipleWriter = MultipleLogWriter.GetMLWInstance( new ILogWriter[2] { fileWriter, consoleWriter });
            

            multipleWriter.LogInfo("Information");
            multipleWriter.LogWarning("Warning");
            multipleWriter.LogError("Error");
        }
    }
}