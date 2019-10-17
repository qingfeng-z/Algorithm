#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace ConsoleApp2
{
    using System;
    using System.Linq;

    /*
     *   有一个长度为N的数组，如 int[] arr = {1,12,-13,115,-50,35};找出数组中哪两个节点间所有节点之和的值最大，输出起止节点下标及和
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
        }

        private static void conindex(int[] arr)
        {
            var arrdict = arr.ToDictionary(s => s);
            int start = 0;
            int end = 0;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
              var num = arrdict[start] + arrdict[i + 1];
                if (num > max)
                {
                    max = num;
                    start = i;
                    end = i + 1;
                }
            }

            Console.WriteLine($"{start}{end}{max}");
        }
    }
}
