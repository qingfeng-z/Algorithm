#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        // 给定一个整数数组，判断是否存在重复元素。
        // 如果任何值在数组中出现至少两次，函数返回 true。如果数组中每个元素都不相同，则返回 false。

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 3, 4, 5, 6, 8, 7, };
            Console.WriteLine(IsContains(arr) ? "true" : "false");
            Console.ReadLine();
        }

        /// <summary>
        /// The is contains.
        /// </summary>
        /// <param name="arr">
        /// The arr.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool IsContains(int[] arr)
        {
            var h = new HashSet<int>(arr);
            return h.Count != arr.Length;
        }
    }
}
