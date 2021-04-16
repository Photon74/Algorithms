using System;

namespace Lesson1.App1
{
    public class Lesson1App1
    {
        static void Main(string[] args)
        {
        }

        public static bool IsSimple(int n)
        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            if (d == 0)
            {
                return true;
            }
            return false;
        }
    }
}
