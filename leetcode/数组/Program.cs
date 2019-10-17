#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace 数组
{
    #region region

    using System;
    using System.Linq;

    using Utils;

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

            // array 常用类库的练习
            ArrayMethod.ArrayMethodTest();
            
            /*
             *数组  Array
             * 优势, 查询效率 高， 增，删，改 慢
             */

            // 创建容量为10 的数组 
            var arr1 = new int[]{1,2,4,8,3};
            arr1.ArrMsort();
            
            // 赋值
            Console.WriteLine(arr1.ArrToString());
            Console.ReadLine();
            // 查  时间 O(1)
            var a1 = arr1[0];
            
            // 末尾添加  (时间O(1)) 如果数组已经满了，出错：数组下标越界
            arr1.Append(1);
            // 首部||中部添加 会将下标之后的值统一向后面移动
            var num = 0;
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                num = arr1[i];
                arr1[i] = arr1[i + 1];
            }

            arr1[arr1.Length - 1] = num;
            var a = arr1.ArrToString();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
