using Lesson1.App3;
using Xunit;

namespace Lesson1.Tests
{
    public class Lesson1App3Tests
    {
        [Fact]
        public void FibonacciRecursion_3_2Returned()
        {
            // arrange
            int n = 3;
            int expected = 2;

            // act
            Lesson1App3 app3 = new Lesson1App3();
            int actual = app3.FibonacciRecursion(n);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FibonacciRecursion_5_5Returned()
        {
            // arrange
            int n = 5;
            int expected = 5;

            // act
            Lesson1App3 app3 = new Lesson1App3();
            int actual = app3.FibonacciRecursion(n);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FibonacciRecursion_12_144Returned()
        {
            // arrange
            int n = 12;
            int expected = 144;

            // act
            Lesson1App3 app3 = new Lesson1App3();
            int actual = app3.FibonacciRecursion(n);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Fibonacci_Not_Recursion_13_233Returned()
        {
            // arrange
            int n = 13;
            int expected = 233;

            // act
            Lesson1App3 app3 = new Lesson1App3();
            int actual = app3.FibonacciRecursion(n);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Fibonacci_Not_Recursion_14_377Returned()
        {
            // arrange
            int n = 14;
            int expected = 377;

            // act
            Lesson1App3 app3 = new Lesson1App3();
            int actual = app3.FibonacciRecursion(n);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Fibonacci_Not_Recursion_15_610Returned()
        {
            // arrange
            int n = 15;
            int expected = 610;

            // act
            Lesson1App3 app3 = new Lesson1App3();
            int actual = app3.FibonacciRecursion(n);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
