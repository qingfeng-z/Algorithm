#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace 递归
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
            Console.WriteLine("Hello World!");
            var sum = GetSum(3); // 3 * 2 * 1
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        /// <summary>
        /// 1 * 2 * 3
        /// </summary>
        /// <param name="num">
        /// The num.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetSum(int num)
        {
            if (num == 1)
            {
                return num;
            }

            return num * GetSum(num - 1);
        }

        /*
         *调用栈视图
         *      .1 调用栈  getsum  name ：num
         *      .2 getsum 挂起, 调用栈getSum（2） 压入
         *      .3 getSum（2）挂起 调用栈 getSum(3) 压入
         *      .4 getSum(3) 执行完成， 调用栈 getSum(3) 弹出
         *      .5 getSum(2) 继续持续， 执行完成， 调用栈 getSum(2) 弹出
         *      .6 getSum 继续持续， 执行完成， 调用栈 getSum 弹出
         *      .7 返回
         ******************* address as ads
         *         ------------
         *         |getSum(3)-|
         *         |----------|
         *         |-Name|sum-|
         *         |-ads-|x02-|
         *         ------------
         *         |getSum(2)-|
         *         |----------|
         *         |-Name|sum-|
         *         |-ads-|x01-|
         *         ------------
         *         |--getSum--|
         *         |----------|
         *         |-Name|sum-|
         *         |----------|
         *         |-ads-|x00-|
         *         ------------
         *
         *
         *
         */


    }
}
