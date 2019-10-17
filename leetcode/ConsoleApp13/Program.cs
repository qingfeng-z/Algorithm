#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace ConsoleApp13
{
    using System;
    using System.Collections.Generic;

    /*
     *将一个按照升序排列的有序数组，转换为一棵高度平衡二叉搜索树。
      本题中，一个高度平衡二叉树是指一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过 1。
      示例:

      给定有序数组: [-10,-3,0,5,9],
 
      一个可能的答案是：[0,-3,9,-10,null,5]，它可以表示下面这个高度平衡二叉搜索树：
 
           0
          / \
        -3   9
        /   /
      -10  5
     *
     */
    public enum ServiceType
    {
        /// <summary>
        ///     The 上门.
        /// </summary>
        上门 = 1,

        /// <summary>
        ///     The 到店.
        /// </summary>
        到店 = 2,

        /// <summary>
        ///     The 邮寄.
        /// </summary>
        邮寄 = 4
    }

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The get tree.
        /// </summary>
        /// <param name="serviceTypes">
        /// The service Types.
        /// </param>
        /// <returns>
        /// The <see cref="int[]"/>.
        /// </returns>
        public static int[] GetTree(List<ServiceType> serviceTypes)
        {
            var a = string.Join(",", serviceTypes);
            if (Enum.TryParse(a, out ServiceType serviceType))
            {

            }

            var e = serviceType;
            return new[] { 1 };
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
        private static void Main(String[] args)
        {
            Console.WriteLine("Hello World!");
            GetTree(new List<ServiceType> { ServiceType.上门, ServiceType.到店, ServiceType.邮寄 });
        }
    }
}
