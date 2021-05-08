using System;

namespace NumberOfRoutes
{
    public class ArrayRoutesWithObstacles
    {
        static public int i = 0;
        static int[,] obstacles =
        {
            {1, 1, 1, 1 },
            {1, 1, 1, 1 },
            {1, 1, 1, 0 },
            {1, 0, 0, 1 }
        };

        public static int CountRoutes(int a, int b)
        {
            i++;

            if (!(a > obstacles.GetLength(0) - 1) && !(b > obstacles.GetLength(1) - 1))
            {
                if (obstacles[a, b] == 0) return 0; 
            }

            return a == 0 || b == 0 ? 1 : CountRoutes(a, b - 1) + CountRoutes(a - 1, b);
        }
    }
}