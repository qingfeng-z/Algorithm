using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    static class LeetCode分割平衡字符串
    {
        /*
         * 在一个「平衡字符串」中，'L' 和 'R' 字符的数量是相同的。
            给出一个平衡字符串 s，请你将它分割成尽可能多的平衡字符串。
            返回可以通过分割得到的平衡字符串的最大数量。
         */
        public static int balancedStringSplit(string s)
        {
            var sum = 0;
            var k1 = 0;
            var k2 = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R') k1++;
                else k2++;
                if (k1 == k2) sum++;
            }
            return sum;
        }


    }
}
