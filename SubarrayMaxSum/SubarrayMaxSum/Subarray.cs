using System;
using System.Collections.Generic;

namespace SubarrayMaxSum
{
    public class Subarray
    {
        public static void GetMaxSum(int[] arr)
        {
            var begin = 0;
            var last = 0;
            var sum = 0;
            var indices = new List<Indices>();

            var i = 0;
            while(i > 0 && i < arr.Length && arr[i] < 0)
            {
                i++;
            }

            begin = i;
            last = i;
            sum += arr[i];

            for(i = i + 1; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    if (sum > 0 && last == i - 1)
                    {
                        indices.Add(new Indices
                        {
                            Begin = begin,
                            Last = last,
                            Sum = sum
                        });
                    }
                }
                else
                {
                    if (last == i - 1)
                    {
                        sum += arr[i];
                        last = i;
                    }
                    else
                    {
                        begin = i;
                        last = i;
                        sum = arr[i];
                    }

                }
            }

            if(last == i - 1)
            {
                indices.Add(new Indices
                {
                    Begin = begin,
                    Last = last,
                    Sum = sum
                });
            }

            var result = FindLocalMax(indices);

            Console.WriteLine(result.Begin + " - " + result.Last + " sum = " + result.Sum);
        }

        private static Indices FindLocalMax(IList<Indices> indices)
        {
            var i = 0;

            Indices result = null;

            var begin = indices[0].Begin;
            var last = indices[0].Last;
            var sum = indices[0].Sum;

            for (i = 1; i < indices.Count; i++)
            {
                if (last + 1 == indices[i].Begin)
                {
                    sum += indices[i].Sum;
                    last = indices[i].Last;
                }
                else
                {
                    if (result == null)
                    {
                        result = new Indices();

                        result.Sum = sum;
                        result.Begin = begin;
                        result.Last = last;

                    }
                    else
                    {
                        if (result.Sum < sum)
                        {
                            result.Sum = sum;
                            result.Begin = begin;
                            result.Last = last;
                        }
                    }
                    sum = indices[i].Sum;
                    begin = indices[i].Begin;
                    last = indices[i].Last;
                }

            }

            if (result.Sum < sum)
            {
                result.Sum = sum;
                result.Begin = begin;
                result.Last = last;
            }

            return result;
        }

    }
}
