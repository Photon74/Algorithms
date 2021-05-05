using System;

namespace Graf
{
    class Program
    {
        static Random random;

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

            Console.WriteLine(graf1.ToString());

            Graf graf2 = new Graf();    // Второй способ создания графа
            graf2.AddNodeRange(GetRandomIntArray());

            Graf graf3 = new Graf(GetRandomIntArray()); // Третий способ создания графа

            Console.ReadLine();
        }

        static int[] GetRandomIntArray(int size = 7)
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
