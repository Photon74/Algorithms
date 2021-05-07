using System;
using System.Collections.Generic;
using System.Text;

namespace NumberOfRoutes
{
    public class ArrayRoutesWithObstacles
    {
        static public double i = 0;
        static int[,] c =
        {
            {1, 1, 1 },
            {1, 0, 1 },
            {1, 1, 0 }
        };

        public static double CountRoutes(int a, int b)
        {
            i++;
            if (i % 100_000 == 0) Console.WriteLine($"{i} рекурсивных вызовов");

            if (c[a, b] == 0) return 0;

            if (a == 0 || b == 0) return 1;

            return CountRoutes(a, b - 1) + CountRoutes(a - 1, b);
        }

    }
}
