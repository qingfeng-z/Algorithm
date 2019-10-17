using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp15
{
    class Program
    {
        /*
         * 给你一个字符串 text，你需要使用 text 中的字母来拼凑尽可能多的单词 "balloon"（气球）。
            字符串 text 中的每个字母最多只能被使用一次。请你返回最多可以拼凑出多少个单词 "balloon"。
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MaxNumberOfBalloons("");
        }

        public static int MaxNumberOfBalloons(string text)
        {
            var textArr = text.Split(" ");
            var sb = new StringBuilder();
            foreach (var s in textArr)
            {
                sb.Append(s);
            }

            if (sb.Length <= 7 && sb.ToString() == "balloon")
            {
                return 0;
            }

            var balloon = "balloon".ToDictionary(s => s,s => 0);
            foreach (var s in sb.ToString())
            {
                if (balloon.ContainsKey(s))
                {
                    balloon[s] = balloon[s] + 1;
                }
            }

            var min = balloon.Values.Min();

            return min;
        }
    }
}
