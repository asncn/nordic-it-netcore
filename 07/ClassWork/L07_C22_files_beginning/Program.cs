using System;
using System.IO;
using System.Linq;
using System.Text;

namespace L07_C22_files_beginning
{
	class Program
	{
		static void Main(string[] args)
		{
			const string fileName = @"test.txt";
			const string testMessage = "Hello, world!";

			byte[] messageAnsiBytes = Encoding.ASCII.GetBytes(testMessage);

			FileStream testFileStream = File.Open(fileName, FileMode.Create, FileAccess.Write, FileShare.Read);
			testFileStream.Write(messageAnsiBytes);
			testFileStream.Close();

			FileStream testFileStream2 = File.Open(fileName, FileMode.Append, FileAccess.Write);
			StreamWriter streamWriter2 = new StreamWriter(testFileStream2, Encoding.ASCII);
			streamWriter2.Write(Environment.NewLine);
			streamWriter2.Write(new string(testMessage.Reverse().ToArray()));
			streamWriter2.Close();
			testFileStream2.Close();
		}
	}
}
