using Nito.Collections;
using System;

namespace Graf
{
    class Program
    {
        static Random random;
        static int[] arr;

        static void Main(string[] args)
        {
            Graf graf1 = new Graf(); // Первый способ создания графа
            graf1.AddNode(10);
            graf1.AddNode(7);
            graf1.AddNode(12);
            graf1.AddNode(11);
            graf1.AddNode(6);
            graf1.AddNode(14);
            graf1.AddNode(13);
            graf1.AddEdge(10, 12, 1);
            graf1.AddEdge(10, 7, 1);
            graf1.AddEdge(7, 11, 1);
            graf1.AddEdge(12, 11, 1);
            graf1.AddEdge(7, 6, 1);
            graf1.AddEdge(12, 14, 1);
            graf1.AddEdge(6, 13, 1);
            graf1.AddEdge(14, 13, 1);

            Console.WriteLine("graf1: " + graf1.ToString() + "\n");

            Console.WriteLine(graf1.BFS(10) + "\n");

            Console.WriteLine(graf1.DFS(10) + "\n");

            // Два других способа создания узлов в графе
            arr = GetRandomIntArray();
            Graf graf2 = new Graf();
            graf2.AddNodeRange(arr);

            arr = GetRandomIntArray(15);
            Graf graf3 = new Graf(arr);



            Console.ReadLine();
        }


        /// <summary>
        /// Создание массива из случайных целых чисел от 0 до 100
        /// </summary>
        /// <param name="size">Размер массива (по-умолчанию == 10)</param>
        /// <returns></returns>
        private static int[] GetRandomIntArray(int size = 10)
        {
            random = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(100);
            }
            return arr;
        }
    }
}
