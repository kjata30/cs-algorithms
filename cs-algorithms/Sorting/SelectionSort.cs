﻿using System;
using Algorithms.Utils;

namespace Algorithms.Sorting
{
    public class SelectionSort
    {
        public static void Sort<T>(T[] a, int lo, int hi, Comparison<T> comparator)
        {
            for (var i = lo; i < hi; ++i)
            {
                var max = a[i];
                var J = i;
                for (var j = i + 1; j <= hi; ++j)
                {
                    if (SortUtil.IsLessThan(a[j], a[J], comparator))
                    {
                        J = j;
                    }
                }
                SortUtil.Exchange(a, i, J);
            }
        }

        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            Sort(a, 0, a.Length-1, (a1, a2) => a1.CompareTo(a2));
        }
    }
}