#region license
// <copyright company="ZAN LLC" file="ArrayCommon.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion
namespace Utils
{
    using System;
    using System.Text;

    /// <summary>
    /// The class 1.
    /// </summary>
    public static class ArrayCommon
    {
        /// <summary>
        /// The arr to string.
        /// </summary>
        /// <param name="arr">
        /// The arr.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string ArrToString(this Array arr)
        {
            var sb = new StringBuilder();
            sb.Append("[");
            foreach (var i in arr)
            {
                sb.Append($"{i},");
            }

            if (arr.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }

            sb.Append("]");
            return sb.ToString();
        }

        public static Array ArrMsort(this Array arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
            {
                return arr;
            }
            
            // 快速排序的递归实现
            QuickSort((int[])arr, 0, arr.Length - 1);

            return arr;
        }

        private static void QuickSort(int[] list, int low, int high)
        {
            int mid;
            if (low < high)
            {
                mid = Partition(list, low, high);
                QuickSort(list, low, mid - 1);
                QuickSort(list, mid + 1, high);
            }
        }

        private static int Partition(int[] list, int low, int high)
        {
            int temp = list[low];
            while (low < high)
            {
                while (low < high && temp < list[high])
                {
                    high--;
                }

                list[low] = list[high];
                while (low < high && temp > list[low])
                {
                    low++;
                }

                list[high] = list[low];
            }
            list[low] = temp;
            return low;
        }
    }
}
