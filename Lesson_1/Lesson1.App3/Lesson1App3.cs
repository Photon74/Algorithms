namespace Lesson1.App3
{
    public class Lesson1App3
    {
        static void Main(string[] args)
        {
        }

        public int FibonacciRecursion(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }

        public int FibonacciNotRecursion(int n)
        {
            if (n < 2)
            {
                return n;
            }
            int[] arr = { 0, 1, 1 };
            for (int i = 3; i <= n; i++)
            {
                arr[0] = arr[1];
                arr[1] = arr[2];
                arr[2] = arr[0] + arr[1];
            }
            return arr[2];
        }
    }
}
