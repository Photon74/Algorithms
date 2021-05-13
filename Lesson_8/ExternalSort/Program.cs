using System;
using System.Collections.Generic;
using System.IO;

namespace ExternalSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.txt";
            int flushSize = 256;
            int[] vs;
            int[] vs1;

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (FileStream streamWriter = new FileStream(path, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(streamWriter)) // создание файла с массивом
            {
                int[] tempArr = GetRandomArray(5 * (int)FileSize.KByte, 10, 100);
                int count = 0;
                for (int i = 0; i < tempArr.Length; i++)
                {
                    writer.Write(tempArr[i]);
                    if (count % flushSize == 0) writer.Flush();
                }
                vs = tempArr;
            }

            ExternalSort.IntArrayFile(path);

            using (var streamReader = new FileStream(path, FileMode.Open))
            using (var reader = new BinaryReader(streamReader)) // создание файла с массивом
            {
                int i = 0;
                int[] tempArr = new int[1280];
                while (streamReader.Position < streamReader.Length)
                {
                    //for (int i = 0; i < tempArr.Length - 1; i++)
                    //{
                        tempArr[i] = reader.ReadInt32();
                    i++;
                    //}
                }
                vs1 = tempArr;
            }
            Console.WriteLine("?");
            Console.ReadLine();
        }

        static int[] GetRandomArray(int arraySize, int minValue, int maxValue)
        {
            var random = new Random();
            var randomArray = new int[arraySize];
            for (var i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue);
            }
            return randomArray;
        }
    }
}
