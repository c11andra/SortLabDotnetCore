using System;

namespace SortLabDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            TestQuickSort();
        }

        private static void TestQuickSort()
        {
            var arr = new int[] { 5, 9, 10, 3, 4 };
            arr.QuickSort();
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
