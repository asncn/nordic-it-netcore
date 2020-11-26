using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HomeWork_13
{
    class FileLogWriter : BaseLogWriter, ILogWriter
    {
        private string FileName { get; }

        public FileLogWriter(string fileName)
        {
            FileName = fileName;
        }

        public override void WriteMessage(string message, MessageType type)
        {
            var fileStream = File.Open(FileName, FileMode.OpenOrCreate);
            fileStream.Seek(0, SeekOrigin.End);
            var fileWriter = new StreamWriter(fileStream);
            fileWriter.WriteLine(FormatMessage(message, type));
            fileWriter.Close();
            fileStream.Close();
        }
    }
}
