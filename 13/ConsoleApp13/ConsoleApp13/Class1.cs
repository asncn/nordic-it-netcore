using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    interface IWriter : IDisposable
    {
        void Write(string content);
    }
}
