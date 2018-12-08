using System;

namespace SortLabDotNetCore
{
    public static class Extensions{
        public static void QuickSort(this int[] arr)
        {
            Algorithm<int>.QuickSort(arr);
        }
    }
}