using System;
using System.Collections.Generic;
using System.Text;

namespace BucketSort
{
    public class BucketSortClass
    {
        public static int[] BucketSortMethod(int[] a)
        {
            List<int>[] buckets = new List<int>[5];

            for (int i = 0; i < buckets.Length; ++i)
                buckets[i] = new List<int>();

            int minValue = a[0];
            int maxValue = a[0];

            for (int i = 1; i < a.Length; ++i)
            {
                if (a[i] < minValue)
                    minValue = a[i];
                else if (a[i] > maxValue)
                    maxValue = a[i];
            }

            double numRange = maxValue - minValue;

            for (int i = 0; i < a.Length; ++i)
            {
                int bucketIndex = (int)Math.Round((a[i] - minValue) / numRange * (buckets.Length - 1));

                buckets[bucketIndex].Add(a[i]);
            }

            for (int i = 0; i < buckets.Length; ++i)
            {
                buckets[i].Sort();
            }

            int index = 0;

            for (int i = 0; i < buckets.Length; ++i)
            {
                for (int j = 0; j < buckets[i].Count; ++j)
                {
                    a[index++] = buckets[i][j];
                }
            }
            return a;
        }
    }
}
