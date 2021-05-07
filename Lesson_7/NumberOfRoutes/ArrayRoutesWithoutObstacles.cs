using System;

namespace NumberOfRoutes
{
    public class ArrayRoutesWithoutObstacles
    {
        static public double i = 0;
        public static double CountRoutes(int a, int b)
        {
            i++;
            if (i % 100_000 == 0) Console.WriteLine($"{i} рекурсивных вызовов");

            if (a == 0 || b == 0)
            {
                return 1;
            }
            return CountRoutes(a, b - 1) + CountRoutes(a - 1, b);
        }
    }
}