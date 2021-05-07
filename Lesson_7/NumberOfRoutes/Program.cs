using System;
using System.Collections.Generic;
using System.Text;

namespace NumberOfRoutes
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int A = 50;// random.Next(2, 100);
            int B = 50;// random.Next(2, 100);

            double result = ArrayRoutesWithoutObstacles.CountRoutes(A - 1, B - 1);

            Console.WriteLine($"Кол-во выполненных рекурсивных вызовов: {ArrayRoutesWithoutObstacles.i}");
            Console.WriteLine($"Кол-во маршрутов в правый нижний угол массива размерностью {A} на {B} без препятствий = {result}");

            result = ArrayRoutesWithObstacles.CountRoutes(A - 1, B - 1);

            Console.WriteLine($"Кол-во выполненных рекурсивных вызовов: {ArrayRoutesWithoutObstacles.i}");
            Console.WriteLine($"Кол-во маршрутов в правый нижний угол массива размерностью {A} на {B} с препятствиями = {result}");

            Console.ReadLine();
        }
    }
}
