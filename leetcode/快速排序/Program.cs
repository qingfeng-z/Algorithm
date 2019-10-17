#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace 快速排序
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var arr = new List<int> { 1, 2, 3 };
            var sum = GetSum(arr);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        /// <summary>
        /// The get sum.
        /// </summary>
        /// <param name="arr">
        /// The arr.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetSum(List<int> arr)
        {
            if (arr.Count == 0)
            {
                return 0;
            }

            return arr[0] + GetSum(arr.ARemove(arr[0]));
        }

        /// <summary>
        /// The a remove.
        /// </summary>
        /// <param name="arr">
        /// The arr.
        /// </param>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<int> ARemove(this List<int> arr, int index)
        {
            arr.Remove(index);
            return arr;
        }
    }
}

