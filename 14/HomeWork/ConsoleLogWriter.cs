using System;

namespace SingletonWork
{
    public class ConsoleLogWriter : BaseLogWriter
    {
        public override void WriteMessage(string message, MessageType type)
        {
            Console.WriteLine(FormatMessage(message, type));
        }


        private static ConsoleLogWriter instance;
        private ConsoleLogWriter()
        { }
        public static ConsoleLogWriter GetInstance()
        {
            if (instance == null)
                instance = new ConsoleLogWriter();
            return instance;
        }
    }
}
