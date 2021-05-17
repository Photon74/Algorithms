using System;
using System.IO;

namespace ExternalSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = "test.txt";
            const int flushSize = 256;

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (var streamWriter = new FileStream(path, FileMode.Create))
            using (var writer = new BinaryWriter(streamWriter)) // создание файла с массивом
            {
                var tempArr = GetRandomArray(100 * (int)FileSize.KByte, 10, 100);
                for (var i = 0; i < tempArr.Length; i++)
                {
                    writer.Write(tempArr[i]);
                    if (i % flushSize == 0) writer.Flush();
                }
            }

            ExternalSort.IntArrayFile(path);

            Console.WriteLine("\n?");
            Console.ReadLine();
        }

        private static int[] GetRandomArray(int arraySize, int minValue, int maxValue)
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
