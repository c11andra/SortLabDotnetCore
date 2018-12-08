using System;

namespace SortLabDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            TestQuickSort();
            TestMergeSort();
        }

        private static void TestMergeSort()
        {
            var arr = new int[] { 6,11,15,3,29,2,100, 2, 3, 100, 200, 1000, 35 ,1, 4, 6, 12,8, 27};
            Console.WriteLine("===Merge Sort===");
            arr.MergeSort();
            arr.Print();
        }

        private static void TestQuickSort()
        {
            Console.WriteLine("===Quick Sort===");
            var arr = new int[] { 5, 9, 10, 3, 4 };
            arr.QuickSort();
            arr.Print();
           
        }
    }
}
