using System;
using System.Collections.Generic;

namespace 数组
{
    static class ArrayMethod
    {
        public static void ArrayMethodTest()
        {
            var arr = new int[] { 1, 2, 3,1 };
            var arrIntLength = arr.Length; // int 类型
            var arrLongLength = arr.LongLength; // long 类型
            var arr2 = new int[,] { };
            var arrRank = arr.Rank; // 一维数组
            var arrRank2 = arr2.Rank; // 二维数组
            Array.Reverse(arr); // arr = 3，2，1 数组反转
            Array.Sort(arr); // arr = 1,2,3  数组排序 顺序排序
            var arrCopy = new int[3];
            //Array.Copy(arr, arrCopy, arr.Length);
            Array.Clear(arr, 0, arr.Length);
            //如果事先不知道元素的类型，就可以使用该静态方法，因为类型可以作为Type对象传送给CreateInstance()方法。
            var a = 4;

            //var has = new HashSet<int>(arr);
            //if (has.Count < arr.Length)
            //{
            //    return true;
            //}

            // 这里是数组
            arr = new int[] { 1, 2, 3, 1 };
            var res = true;
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    res =   i - dict[arr[i]] <= a;
                    if (res)
                    {
                     //    res;
                    }
                    else
                    {
                        dict[arr[i]] = i;
                    }
                }
                else
                {
                    dict.Add(arr[i],i);
                }
            }
        }
    }
}
