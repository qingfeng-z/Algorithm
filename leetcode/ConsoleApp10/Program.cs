#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace ConsoleApp10
{
    #region region

    using System;

    #endregion
    /*
     * 给定一个正整数 N，试求有多少组连续正整数满足所有数字之和为 N?
     */

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
            Console.WriteLine("Hello World!");
            var e = ConsecutiveNumbersSum(15);
            Console.WriteLine(e);
            Console.ReadLine();
        }

        /// <summary>
        /// The consecutive numbers sum.
        /// </summary>
        /// <param name="N">
        /// The n.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int ConsecutiveNumbersSum(int N)
        {
            int num = 1;
            int n = 2 * N;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    int end = (n / i + i - 1) / 2;
                    int start = end - n / i + 1;
                    if ((start + end) * (end - start + 1) == n)
                    {
                        num++;
                    }
                }
            }
            return num;
        }
    }
}
