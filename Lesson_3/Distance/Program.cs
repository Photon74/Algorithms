using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distance
{
    public class Program
    {
        private static int size = 100;
        static Random random = new Random();

        static PointClass pointClass;
        static PointStruct<float> floatPointStruct;
        static PointStruct<double> doublePointStruct;

        static PointClass[] classPointsArr = new PointClass[size];
        static PointStruct<float>[] floatStructPointsArr = new PointStruct<float>[size];
        static PointStruct<double>[] doubleStructPointsArr = new PointStruct<double>[size];

        public static void InitArrays()
        {
            for (int i = 0; i < classPointsArr.Length; i++)
            {
                pointClass = new PointClass
                {
                    X = random.Next(0, size),
                    Y = random.Next(0, size)
                };
                classPointsArr[i] = pointClass;
            }

            for (int i = 0; i < floatStructPointsArr.Length; i++)
            {
                floatPointStruct = new PointStruct<float>
                {
                    X = (float)random.NextDouble() * size,
                    Y = (float)random.NextDouble() * size
                };
                floatStructPointsArr[i] = floatPointStruct;
            }

            for (int i = 0; i < doubleStructPointsArr.Length; i++)
            {
                doublePointStruct = new PointStruct<double>
                {
                    X = random.NextDouble() * size,
                    Y = random.NextDouble() * size
                };
                doubleStructPointsArr[i] = doublePointStruct;
            }
        }
        static void Main(string[] args)
        {
            InitArrays();

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }

        public class BechmarkClass
        {
            [Benchmark]
            public void TestPointDistance()
            {
                CalculationMethods.CountDistanceSimpleClassFloat(classPointsArr, classPointsArr);
            }

            [Benchmark]
            public void TestPointDistanceShort()
            {
                CalculationMethods.CountDistanceSimpleStructFloat(floatStructPointsArr, floatStructPointsArr);
            }

            [Benchmark]
            public void TestPointDistanceDouble()
            {
                CalculationMethods.CountDistanceSimpleStructDouble(doubleStructPointsArr, doubleStructPointsArr);
            }

            [Benchmark]
            public void TestPointDistanceFloat()
            {
                CalculationMethods.CountDistanceNoSqrtStructFloat(floatStructPointsArr, floatStructPointsArr);
            }
        }
    }
}
