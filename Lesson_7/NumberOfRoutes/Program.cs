using System;

namespace NumberOfRoutes
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int A = random.Next(2, 15);
            int B = random.Next(2, 15);

            int result = ArrayRoutesWithoutObstacles.CountRoutes(A - 1, B - 1);

            Console.WriteLine($"Кол-во выполненных рекурсивных вызовов: {ArrayRoutesWithoutObstacles.i}\n");
            Console.WriteLine($"Кол-во маршрутов в правый нижний угол массива" +
                $" размерностью {A} на {B} без препятствий = {result}\n");

            result = ArrayRoutesWithObstacles.CountRoutes(A - 1, B - 1);

            Console.WriteLine($"Кол-во маршрутов в правый нижний угол массива" +
                $" размерностью {A} на {B} с препятствиями = {result}");

            Console.ReadLine();
        }
    }
}