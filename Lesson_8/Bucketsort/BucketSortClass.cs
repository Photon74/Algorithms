using System;
using System.Collections.Generic;
using System.Text;

namespace BucketSort
{
    public class BucketSortClass
    {
        public static int[] BucketSortMethod(int[] arr)
        {
            List<int>[] buckets = new List<int>[5];

            if (arr == null) throw new ArgumentNullException(nameof(arr));

            for (int i = 0; i < buckets.Length; ++i)
                buckets[i] = new List<int>();

            int minValue = arr[0];
            int maxValue = arr[0];

            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] < minValue)
                    minValue = arr[i];
                else if (arr[i] > maxValue)
                    maxValue = arr[i];
            }

            double numRange = maxValue - minValue;

            for (int i = 0; i < arr.Length; ++i)
            {
                int bucketIndex = (int)Math.Round((arr[i] - minValue) / numRange * (buckets.Length - 1));

                buckets[bucketIndex].Add(arr[i]);
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
                    arr[index++] = buckets[i][j];
                }
            }
            return arr;
        }
    }
}
