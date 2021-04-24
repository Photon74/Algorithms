using System;

namespace Distance
{
    public class CalculationMethods
    {
        static int size = 10000;
        public static float[] CountDistanceSimpleClassFloat(PointClass[] pointOne, PointClass[] pointTwo)
        {
            int index = 0;
            float x = 0, y = 0;
            float[] result = new float[size];
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                    result[index] = MathF.Sqrt((x * x) + (y * y));
                    index++;
                }
            }
            return result;
        }

        public static float[] CountDistanceSimpleStructFloat(PointStruct<float>[] pointOne, PointStruct<float>[] pointTwo)
        {
            int index = 0;
            float x = 0, y = 0;
            float[] result = new float[size];
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                    result[index] = MathF.Sqrt((x * x) + (y * y));
                    index++;
                }
            }
            return result;
        }

        public static double[] CountDistanceSimpleStructDouble(PointStruct<double>[] pointOne, PointStruct<double>[] pointTwo)
        {
            int index = 0;
            double x = 0, y = 0;
            double[] result =new double[size];
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                    result[index] = MathF.Sqrt((float)((x * x) + (y * y)));
                    index++;
                }
            }
            return result;
        }

        public static float[] CountDistanceNoSqrtStructFloat(PointStruct<float>[] pointOne, PointStruct<float>[] pointTwo)
        {
            int index = 0;
            float x = 0, y = 0;
            float[] result = new float[size];
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                    result[index] = (x * x) + (y * y);
                    index++;
                }
            }
            return result;
        }
    }
}