using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distance
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }

        public class BechmarkClass
        {
            PointStruct point1 = new PointStruct { X = 10, Y = 15 };
            PointStruct point2 = new PointStruct { X = 20, Y = 27 };

            [Benchmark]
            public void TestPointDistance()
            {
                CalculationMethods.PointDistance(point1, point2);
            }

            [Benchmark]
            public void TestPointDistanceShort()
            {
                CalculationMethods.PointDistanceShort(point1, point1);
            }

            [Benchmark]
            public void TestPointDistanceDouble()
            {
                CalculationMethods.PointDistanceDouble(point1, point1);
            }

            [Benchmark]
            public void TestPointDistanceFloat()
            {
                CalculationMethods.PointDistanceFloat(point1, point1);
            }
        }
    }
}
