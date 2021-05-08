using NUnit.Framework;
using NumberOfRoutes;

namespace ArrayRoutesTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2, 2, 2, TestName = "Arr[2,2]; Expected = 2")]
        [TestCase(3, 3, 6, TestName = "Arr[3,3]; Expected = 6")]
        [TestCase(4, 4, 20, TestName = "Arr[4,4]; Expected = 20")]
        [TestCase(5, 5, 70, TestName = "Arr[5,5]; Expected = 70")]
        [TestCase(6, 6, 252, TestName = "Arr[6,6]; Expected = 252")]
        public void Array_Without_Obstacles_Test(int v1, int v2, int expected)
        {
            int actual = ArrayRoutesWithoutObstacles.CountRoutes(v1 - 1, v2 - 1);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, 2, TestName = "Arr[2,2]; Expected = 2 (With Obstacles)")]
        [TestCase(3, 3, 6, TestName = "Arr[3,3]; Expected = 6 (With Obstacles)")]
        [TestCase(4, 4, 0, TestName = "Arr[4,4]; Expected = 0 (With Obstacles)")]
        [TestCase(5, 5, 6, TestName = "Arr[5,5]; Expected = 6 (With Obstacles)")]
        [TestCase(6, 6, 32, TestName = "Arr[6,6]; Expected = 32")]
        public void Array_With_Obstacles_Test(int v1, int v2, int expected)
        {
            int actual = ArrayRoutesWithObstacles.CountRoutes(v1 - 1, v2 - 1);

            Assert.AreEqual(expected, actual);
        }

    }
}