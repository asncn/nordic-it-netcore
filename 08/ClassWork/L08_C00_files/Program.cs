using System;
using System.IO;
using System.Text;

namespace L08_C00_files
{
	class Program
	{
		static void Main(string[] args)
		{
			const string fileName = @"c:\test.txt";
			const string content = "Never mind 2";

			//FileStream stream = File.Create(
			//	fileName, 
			//	4096);

			// for writing
			//FileStream stream = File.Open(
			//	fileName,
			//	FileMode.OpenOrCreate,
			//	FileAccess.ReadWrite,
			//	FileShare.Read);

			//stream.Seek(0, SeekOrigin.End);

			// byte[] bytesOfContent =
			//	Encoding.ASCII.GetBytes(content);

			//stream.WriteByte(13);
			//stream.WriteByte(10);

			//stream.Write(bytesOfContent);

			//stream.Flush();
			//stream.Close();

			// for reading
			FileStream stream = File.Open(
				fileName,
				FileMode.Open,
				FileAccess.Read,
				FileShare.Read);

			const int readBufferSize = 5;
			byte[] bytesOfContent = new byte[readBufferSize];
			string result = String.Empty;
			int bytesRead;

			do
			{
				bytesRead = stream.Read(
					bytesOfContent,
					0,
					readBufferSize);

				result += Encoding.ASCII.GetString(
					bytesOfContent,
					0,
					bytesRead);

			} while (bytesRead > 0);
			
			stream.Close();

			Console.WriteLine(result);
		}
	}
}
