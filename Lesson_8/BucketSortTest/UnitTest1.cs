using NUnit.Framework;
using BucketSort;
using System;
using System.Linq;

namespace BucketSortTest
{
    public class Tests
    {     
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BucketSort_Test1()
        {
            int[] arr = GetRandomArray(100, 1, 100);

            int[] actual = BucketSortClass.BucketSortMethod(arr);
            int[] expected = arr.OrderBy(i => i).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BucketSort_Test2()
        {
            int[] arr = GetRandomArray(100, -100, 0);

            int[] actual = BucketSortClass.BucketSortMethod(arr);
            int[] expected = arr.OrderBy(i => i).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BucketSort_Test3()
        {
            int[] arr = GetRandomArray(100, -100, 100);

            int[] actual = BucketSortClass.BucketSortMethod(arr);
            int[] expected = arr.OrderBy(i => i).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BucketSort_Exception_Test4()
        {
            int[] arr = GetRandomArray(0, 1, 100);

            Assert.That(() => BucketSortClass.BucketSortMethod(arr), Throws.TypeOf<IndexOutOfRangeException>());

        }
        static int[] GetRandomArray(int arraySize, int minValue, int maxValue)
        {
            var random = new Random();
            var randomArray = new int[arraySize];
            for (var i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue);
            }
            return randomArray;
        }

    }
}