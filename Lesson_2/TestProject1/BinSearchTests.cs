using Lesson2.App2;
using NUnit.Framework;

namespace Lesson2.Tests
{
    public class BinSearchTests
    {
        int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BinSearch_4_4expected()
        {
            int searchValue = 4;
            int expected = 4;

            var actual = BinSearch.BinarySearch(arr, searchValue);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinSearch_11_11expected()
        {
            int searchValue = 11;
            int expected = 11;

            var actual = BinSearch.BinarySearch(arr, searchValue);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinSearch_19_19expected()
        {
            int searchValue = 19;
            int expected = 19;

            var actual = BinSearch.BinarySearch(arr, searchValue);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinSearch_25_errorexpected()
        {
            int searchValue = 25;
            int expected = -1;

            var actual = BinSearch.BinarySearch(arr, searchValue);

            Assert.AreEqual(expected, actual);
        }

    }
}