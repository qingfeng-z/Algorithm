#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace 栈
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

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
        /// <returns>
        /// The <see cref="void"/>.
        /// </returns>
        private static void Main(string[] args)
        {
            // 栈 特性 先入后出
            var s = new Stack();
            s.Push(1);
            s.Push(2);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.ReadLine();

            /*
             *  给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。
               
                有效字符串需满足：
                    左括号必须用相同类型的右括号闭合。
                    左括号必须以正确的顺序闭合。
                    注意空字符串可被认为是有效字符串。
             */
            Console.WriteLine("Hello World!");
            var str = "([)]";
            var a = IsValid(str);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        /// <summary>
        /// The is valid.
        /// </summary>
        /// <param name="str">
        /// The s.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsValid(string str)
        {

            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            var stack = new Stack();
            stack.Push(str[0]);
            var dict = new Dictionary<string, string> { { "{", "}" }, { "(", ")" }, { "[", "]" } };
            for (var i = 0; i < str.Length - 1; i++)
            {
                var strChar = str[i + 1].ToString();

                if (stack.Count == 0)
                {
                    stack.Push(strChar);
                    continue;
                }

                var s = stack.Pop().ToString();

                if (dict.Keys.Contains(s))
                {
                    var d = dict[s];
                    if (d == strChar) continue;

                    stack.Push(s);
                    stack.Push(strChar);
                }
                else
                {
                    stack.Push(s);
                }
            }

            return stack.Count == 0;
        }

        public void Paramverify(string str)
        {
        }
    }
}
