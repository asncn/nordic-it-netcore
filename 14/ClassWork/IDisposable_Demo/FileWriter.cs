using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IDisposable_Demo
{
	public class FileWriter
	{
		private FileStream _fileStream;
		private Encoding _encoding;

		public FileWriter(string fileName)
		{
			_fileStream = File.Open(
				fileName,
				FileMode.OpenOrCreate,
				FileAccess.Write,
				FileShare.Read);

			_encoding = Encoding.UTF8;


		}

		public FileWriter(string fileName, Encoding encoding)
			:this(fileName)
		{
			
			_encoding = encoding;
		}



		public void Write(string content)
		{
			byte[] bytes = _encoding.GetBytes(content);
			_fileStream.Write(bytes);
		}

		public void Close()
		{
			_fileStream.Close();
		}
	}
}
