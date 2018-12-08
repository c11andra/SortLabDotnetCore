using System;

namespace SortLabDotNetCore
{
    public static partial class Algorithm<T> where T:IComparable
    {

        public static void MergeSort(T[] arr)
        {
            MergeSort(arr, 0, arr.Length-1);
        }
        private static void MergeSort(T[] arr, int left, int right)
        {
            if(left >= right)
            {
                return;
            }
            var mid = (left + right)/2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr,left, mid, mid+1, right);
        }

        private static void Merge(T[] arr, int lStart, int lEnd, int rStart, int rEnd)
        {
            if(lStart == rEnd)
            {
                return;
            }
            var lCount = lEnd-lStart + 1;
            var rCount = rEnd-rStart + 1;
            var tempArr = new T[lCount+rCount];

            var l = lStart;
            var r = rStart;
            var tCount = 0;
            while(l <= lEnd && r <= rEnd)
            {
                if(arr[l].CompareTo(arr[r]) <=0)
                {
                    tempArr[tCount++] = arr[l++];
                }
                else 
                {
                    tempArr[tCount++] = arr[r++];
                }
            }

            while(l <= lEnd)
            {
                tempArr[tCount++] = arr[l++];
            }
            
            while(r <= rEnd)
            {
                tempArr[tCount++] = arr[r++];
            }
            var count = 0;
            for (int i = lStart; i <= rEnd; i++)
            {
                arr[i] = tempArr[count++];
            }
        }

    }
}