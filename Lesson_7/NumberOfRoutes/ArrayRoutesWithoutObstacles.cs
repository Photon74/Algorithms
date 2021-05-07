using System;

namespace NumberOfRoutes
{
    class ArrayRoutesWithoutObstacles
    {
        static Random random = new Random();
        static double i = 0;
        public static double CountRoutes(double a, double b)
        {
            i++;
            if (i % 100_000_000 == 0) Console.WriteLine(i++);

            if (a == 0 || b == 0)
            {
                return 1;
            }
            return CountRoutes(a, b - 1) + CountRoutes(a - 1, b);
        }

        static void Main(string[] args)
        {
            double A = 50;// random.Next(2, 100);
            double B = 50;// random.Next(2, 100);

            double result = CountRoutes(A - 1, B - 1);

            Console.WriteLine(i);
            Console.WriteLine($"Кол-во маршрутов в правый нижний угол массива размерностью {A} на {B} = {result}");

            Console.ReadLine();
        }
    }
}
