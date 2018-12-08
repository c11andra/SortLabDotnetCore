using System;

namespace SortLabDotNetCore
{

    public static partial class Algorithm<T> where T:IComparable
    {
        public static void QuickSort(T[] arr)
        {
            QuickSort(arr, 0, arr.Length-1);
        }
        ///The basic idea is to choose an element called pivot.
        ///Then move items less than pivot to left
        ///Move items greater than pivot to right
        ///The pivot is in its sorted position now.
        ///Repeat the same for items on the left of pivot
        ///and for items on the right of pivot
        private static void QuickSort(T[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int pivot = Partition(arr, left, right);
            if (pivot != -1)
            {
                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }

        }

        private static int Partition(T[] arr, int left, int right)
        {
            var currLength = right - left + 1;
            if (currLength == 1)
            {
                return -1;
            }
            var pivot = right;

            var j = left;
            while (j <= right)
            {
                if (
                    (j < pivot && arr[j].CompareTo(arr[pivot]) <= 0)
                 || (j > pivot && arr[j].CompareTo(arr[pivot]) >=0)
                 || j == pivot)
                {
                    j++;
                }
                else
                {
                    Swap(arr, j, pivot);
                    var temp = pivot;
                    pivot = j;
                    if (temp < j)
                    {
                        j = temp;
                    }

                }
            }
            return pivot;

        }

        private static void Swap(T[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}