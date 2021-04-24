using System;

namespace Distance
{
    public class CalculationMethods
    {
        public static float CountDistanceSimpleClassFloat(PointClass[] pointOne, PointClass[] pointTwo)
        {
            float x = 0, y = 0;
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                }
            }
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static float CountDistanceSimpleStructFloat(PointStruct<float>[] pointOne, PointStruct<float>[] pointTwo)
        {
            float x = 0, y = 0;
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                }
            }
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static double CountDistanceSimpleStructDouble(PointStruct<double>[] pointOne, PointStruct<double>[] pointTwo)
        {
            double x = 0, y = 0;
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                }
            }
            return MathF.Sqrt((float)((x * x) + (y * y)));
        }

        public static float CountDistanceNoSqrtStructFloat(PointStruct<float>[] pointOne, PointStruct<float>[] pointTwo)
        {
            float x = 0, y = 0;
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                }
            }
            return (x * x) + (y * y);
        }
    }
}