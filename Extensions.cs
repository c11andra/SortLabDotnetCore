using System;

namespace SortLabDotNetCore
{
    public static class Extensions{
        public static void QuickSort(this int[] arr)
        {
            Algorithm<int>.QuickSort(arr);
        }
        public static void MergeSort(this int[] arr)
        {
            Algorithm<int>.MergeSort(arr);
        }

        public static void Print(this int[] arr)
        {
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}