using System;

namespace SortLabDotNetCore
{
    public static class Extensions{
        public static void QuickSort(this int[] arr)
        {
            Algorithm.QuickSort(arr,0,arr.Length-1);
        }
    }
}