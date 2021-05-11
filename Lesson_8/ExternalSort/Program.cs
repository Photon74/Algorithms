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
            //List<string> partFiles = new List<string>();
            int[] vs;  // массив для контроля


            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate))) // создание файла с массивом
            {
                int[] tempArr = GetRandomArray(5 * (int)FileSize.MByte, 10, 100);

                for (int i = 0; i < tempArr.Length; i++)
                {
                    writer.Write(tempArr[i]); 
                }
                vs = tempArr;
            }

            ExternalSort.IntArrayFile(path);

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
