﻿using System;
using System.IO;
using System.IO.Compression;

namespace RandomGenerator
{
    class Program
    {
        
          static void Main(string[] args)
        {
            const int totalNumberOfBytes = 1_000;
            const int packSize = 170;

            const string binaryFileName = "random_data.bin";

            var generator = new RandomDataGenerator();

            generator.RandomDataGenerated += (bytesDone, totalBytes) =>
             {
                 Console.WriteLine($"Generated {bytesDone} of {totalBytes} bytes...");
             };

            generator.RandomDataGenerationDone += (sender, eventArgs) =>
            {
                Console.WriteLine("Work done!"); 
            };

            generator.GetRandomData(totalNumberOfBytes, packSize);

            byte[] data = generator.GetRandomData(totalNumberOfBytes, packSize);
            Console.WriteLine(Convert.ToBase64String(data));


            if (File.Exists(binaryFileName)) File.Delete(binaryFileName);

            File.WriteAllBytes(binaryFileName, data);
            var zipFileName = binaryFileName.Remove(binaryFileName.LastIndexOf('.')) + ".zip";

            if (File.Exists(zipFileName)) File.Delete(zipFileName);

            using  ZipArchive archive = ZipFile.Open(zipFileName, ZipArchiveMode.Create);
                archive.CreateEntryFromFile(binaryFileName, binaryFileName);      


        }
    }
}
