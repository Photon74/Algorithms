using System;
using System.IO;

namespace ExternalSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ExternalSorter";

            ExternalSort sorter = new ExternalSort();
            const string path = "test.txt";
            const int flushSize = 256;

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (var streamWriter = new FileStream(path, FileMode.Create))
            using (var writer = new BinaryWriter(streamWriter)) // создание файла с массивом
            {
                var tempArr = GetRandomArray(250 * (int)FileSize.KByte, 10, 100);
                for (var i = 0; i < tempArr.Length; i++)
                {
                    writer.Write(tempArr[i]);
                    if (i % flushSize == 0) writer.Flush();
                }
            }

            sorter.OnProgressUpdateEvent += PrintPercents;
            sorter.IntArrayFile(path);

            Console.WriteLine("\n");
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

        private static void PrintPercents(int percent)
        {
            string str = @" ░▒▓█▓▒░";
            string str2 = @"► ";

            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            Console.Write($"Выполнено: {percent} %");
            Console.Write($" {str[percent % str.Length]}");

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, 1);
            Console.Write(new string(' ', 50));
            Console.SetCursorPosition(0, 1);
            Console.Write(new string('█', percent / 2));
            Console.Write($"{str2[percent % str2.Length]}");

            Console.ResetColor();
            //Console.SetCursorPosition(0, 2);
            //Console.Write($"{str[percent % str.Length]}");
        }
    }
}
