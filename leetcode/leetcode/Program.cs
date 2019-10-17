#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion
namespace Leetcode
{
    using leetcode;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            //queens = [[5, 6],[7,7],[2,1],[0,7],[1,6],[5,1],[3,7],[0,3],[4,0],[1,2],[6,3],[5,0],[0,4],[2,2],[1,1],[6,4],[5,4],[0,0],[2,6],[4,5],[5,2],[1,4],[7,5],[2,3],[0,5],[4,2],[1,0],[2,7],[0,1],[4,6],[6,1],[0,6],[4,3],[1,7]], king = [3,4]
            //   var queens = new int[][] { {5,6},[7, 7],[2, 1],[0, 7],[1, 6],[5, 1],[3, 7],[0, 3],[4, 0],[1, 2],[6, 3],[5, 0],[0, 4],[2, 2],[1, 1],[6, 4],[5, 4],[0, 0],[2, 6],[4, 5],[5, 2],[1, 4],[7, 5],[2, 3],[0, 5],[4, 2],[1, 0],[2, 7],[0, 1],[4, 6],[6, 1],[0, 6],[4, 3],[1, 7]}；
            var king = new int[] { 3, 4 };
            var qiuwe = LeetCode攻击国王的皇后.QueensAttacktheKing(null, king);


            //"RLRRLLRLRL"
            var s = LeetCode分割平衡字符串.balancedStringSplit("RLRRLLRLRL");

            var nums = new int[]{ 1, 2, 2, 2, 3 };
            LeetCode删除排序数组中的重复项.RemoveDuplicates(nums);
            var strs = new string[] { "asd", "asdaf" };
            LeetCode最长公共前缀.LongestCommonPrefix(strs);
            var num = 213;
            var ss  = LeetCode整数反转.reverse(num);

            

            var str = "bbbbb";

            var leet2 = new LeetCode两数相加();
            leet2.LengthOfLongestSubstring(str);
            var leet = new LeetCode俩数之和();
            var arr = new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
            var s1 = leet.TwoSum(arr, 542);
            var s2 = leet.TwoSum2(arr, 542);
            Console.WriteLine("strat");
            Dict();
            Console.WriteLine("end");
            Console.ReadLine();
        }

        /// <summary>
        /// The 字典.
        /// </summary>
        public static void Dict()
        {
            var list = new List<Sample>();
            list.Add(new Sample { id = 1, value = "第一" });
            list.Add(new Sample { id = 2, value = "第二" });
            list.Add(new Sample { id = 3, value = "第三" });

            var listDict = list.ToDictionary(l => l.id, l => l);
            foreach (var listDictValue in listDict.Values)
            {
                Console.WriteLine(listDictValue.value);
            }

            var dict = new Dictionary<long, string> { { 1, "one" }, { 2, "two" }, { 3, "three" } };
            var keys = dict.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            var values = dict.Values;
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            var valueIndex = dict[1];
            Console.WriteLine(valueIndex);
        }

        /// <summary>
        /// The sample.
        /// </summary>
        public class Sample
        {
            public long id { get; set; }
            public string value { get; set; }
        }


        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="arr">
        /// The arr.
        /// </param>
        /// <param name="num">
        /// The num.
        /// </param>
        private static void Get(int[] arr, int num)
        {
            var hashSet = new HashSet<int>(arr);
            foreach (var i in hashSet)
            {
                int s = num - i;
                if (hashSet.Contains(s) && s != i && s > i)
                {
                    Console.WriteLine($"i:{i},s:{s}");
                }
            }
        }
    }
}
