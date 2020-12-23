using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerator
{
	public delegate void RandomDataGeneratedHandler(int bytesDone, int totalBytes);

	public class RandomDataGenerator
	{
		public event EventHandler RandomDataGenerationDone;
		public event RandomDataGeneratedHandler RandomDataGenerated;

		public byte[] GetRandomData(int dataSize, int bytesDoneToRaiseEvent)

		{
			if (dataSize < bytesDoneToRaiseEvent)
				throw new InvalidOperationException();

			if (bytesDoneToRaiseEvent <= 0)
				throw new InvalidOperationException();

			//if (bytesDoneToRaiseEvent <= dataSize)
			//	throw new InvalidOperationException();
			var random = new Random();
			byte[] result = new byte[dataSize];
			byte[] pack = new byte[bytesDoneToRaiseEvent];

			int fullPacksCount = dataSize / bytesDoneToRaiseEvent;
			int lastPackSize  = dataSize % bytesDoneToRaiseEvent;


			for (int i = 0; i < fullPacksCount; i++)
            {
				random.NextBytes(pack);
				pack.CopyTo(result, i * bytesDoneToRaiseEvent);

				RandomDataGenerated?.Invoke((i + 1) * bytesDoneToRaiseEvent, dataSize );
			}

			if (lastPackSize > 0)
			{
				random.NextBytes(pack);
				Array.Copy(pack, 0, result, fullPacksCount * bytesDoneToRaiseEvent, lastPackSize);
			}			
			
			return result;

		

		}
	}

}
