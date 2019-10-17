#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace 二进制
{
    #region region

    using System;
    using System.Threading;

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
            var a = 3;          // 011
            var b = 5;          // 101
            var e = a ^ b;    // 110      相等 0 ，不等 1    6

            e = 2 >> 1;
            /*
             * 1 -     0001
             *          0100 = 4
             * 
             */
            var l = 1 & 2;


            Console.WriteLine("Hello World!");
            HasAlternatingBits(100);
        }

        public static bool HasAlternatingBits(int n)
        {
            var e = n >> 1;
            var c = n ^ e;
            n = n ^ (n >> 1);
            return (n & ((long)n + 1)) == 0;
        }
    }
}
