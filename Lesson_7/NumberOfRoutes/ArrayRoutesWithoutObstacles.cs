using System;

namespace NumberOfRoutes
{
    public class ArrayRoutesWithoutObstacles
    {
        static public int i = 0;
        public static int CountRoutes(int a, int b)
        {
            i++;
            return a == 0 || b == 0 ? 1 : CountRoutes(a, b - 1) + CountRoutes(a - 1, b);
        }
    }
}