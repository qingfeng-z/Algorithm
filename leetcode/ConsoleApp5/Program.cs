#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace ConsoleApp5
{
    #region region

    using System;

    #endregion

    // 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        private static bool IsPalindrome(int x)
        {
            if (x == 0)
            {
                return true;
            }

            var a = x.ToString();
            var index = a.Length / 2;
            if (a.Length / 2 != 0)
            {
                index -= 1;
            }

            for (int i = 0; i < index; i++)
            {
                if (a[i] != a[a.Length - i])
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
