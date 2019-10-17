#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace 获取都为最大的正方形需几步
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The get step.
        /// </summary>
        /// <param name="height">
        /// The height.
        /// </param>
        /// <param name="weight">
        /// The weight.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int getStep(int height, int weight)
        {
            if (height >= weight)
            {
                if (height % weight == 0)
                {
                    return 1;
                }

            }
           
            return 1;
        }
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        /// <returns>
        /// The <see cref="void"/>.
        /// </returns>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
