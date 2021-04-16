using Lesson1.App1;
using System;
using Xunit;

namespace Lesson_1.Tests
{
    public class Lesson_1App1Tests
    {
        [Fact]
        public void Test_3_IsSimple()
        {
            // arrange
            int n = 3;

            // act
            Lesson1App1 lesson1 = new Lesson1App1();
            bool actual = lesson1.IsSimple(n);

            // assert
            Assert.True(actual, "Why 3 is not simple?");
        }
        [Fact]
        public void Test_5_IsSimple()
        {
            // arrange
            int n = 5;

            // act
            Lesson1App1 lesson1 = new Lesson1App1();
            bool actual = lesson1.IsSimple(n);

            // assert
            Assert.True(actual, "Why 5 is not simple?");
        }

        [Fact]
        public void Test_7_IsSimple()
        {
            // arrange
            int n = 7;

            // act
            Lesson1App1 lesson1 = new Lesson1App1();
            bool actual = lesson1.IsSimple(n);

            // assert
            Assert.True(actual, "Why 7 is not simple?");
        }

        [Fact]
        public void Test_9_IsNotSimple()
        {
            // arrange
            int n = 9;

            // act
            Lesson1App1 lesson1 = new Lesson1App1();
            bool actual = lesson1.IsSimple(n);

            // assert
            Assert.False(actual, "Why 9 is simple?");
        }

    }
}
