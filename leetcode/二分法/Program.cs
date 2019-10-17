#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace 二分法
{
    #region region

    using System;

    #endregion

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 100 };
            /*
             * 二分法查询 O(log2 n )
             * 普通 O(n)
             */

            var num = 100;
            var index = GetIndex(arr, num);
            Console.WriteLine(index);
            Console.ReadLine();
        }

        /// <summary>
        /// 获取指定数组中指定元素的下标（已排序的数组）
        /// </summary>
        /// <param name="arr">
        /// The arr.
        /// </param>
        /// <param name="num">
        /// The num.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetIndex(int[] arr, int num)
        {
            var start = 0;
            var end = arr.Length - 1;
            while (start <= end)
            {
                // 获取中位数的下标
                var x = (start + end) / 2;
                var y = arr[x];
                if (y == num)
                {
                    return x;
                }

                if (y < num)
                {
                    start = x + 1;
                }
                else
                {
                    end = x - 1;
                }
            }

            return -1;
        }
    }
}
