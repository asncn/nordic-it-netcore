using System;
namespace HomeWork_13

{
    class Program
    {
        static void Main(string[] args)
        {

            ILogWriter consoleWriter = new ConsoleLogWriter();
            var fileWriter = new FileLogWriter(@"C:\Git\nordic-it-netcore\13\HomeWork\log.txt");
            var multipleWriter = new MultipleLogWriter(new ILogWriter[2] { fileWriter, consoleWriter });

            multipleWriter.LogInfo("Information");
            multipleWriter.LogWarning("Warning");
            multipleWriter.LogError("Error");
        }
    }
}