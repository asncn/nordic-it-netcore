using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class ConsoleWiter : IWriter
    {
        public void Dispose()
        {
            Console.WriteLine("освобождение ресурсов");
        }

        public void Write(string content)
        {
            Console.WriteLine(content);                              ;
        }
    }
}
