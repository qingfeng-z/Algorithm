#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace ConsoleApp12
{
    #region region

    using System;
    using System.Collections.Generic;

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
            Console.WriteLine("Hello World!");
            var arr = new int[] { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 };
            var e = CanThreePartsEqualSum(arr);
            Console.WriteLine(e);
            Console.ReadLine();
        }
        public List<int> OddEvenList(List<int> head)
        {

            for (int i = 0; i < head.Count; i++)
            {
                
            }

            return new List<int>();
        }

        public static bool CanThreePartsEqualSum(int[] A)
        {

            var head = 0; //头
            var body = 0; //中部
            var foot = 0; // 尾部
            for (int i = 0; i < A.Length - 3; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    head += A[j];
                }

                for (int j = 0; j < A.Length - 1- i; j++)
                {
                    foot += A[A.Length - 1 - j];
                    if (foot == head)
                    {
                        for (int k = 0; k < A.Length - 1 - i - j; k++)
                        {
                            body += A[i + 1];
                        }

                        if (body == foot)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
