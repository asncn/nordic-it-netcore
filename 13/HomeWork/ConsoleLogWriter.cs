using System;

namespace HomeWork_13
{
    public class ConsoleLogWriter : BaseLogWriter
    {
        public override void WriteMessage(string message, MessageType type)
        {
            Console.WriteLine(FormatMessage(message, type));
        }
    }
}
