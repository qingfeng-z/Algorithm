using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    static class LeetCode最长公共前缀
    {
        public static string LongestCommonPrefix(string[] strs)
        {

            /*
             *    1.声明一个变量 为字符数组中任意一个字符串，
             *    2.遍历字符串数组
             *    3.获取字符串，为声明变量的下标，
             *    4. 存在， 遍历下一个字符串 | 不存在， 截取声明变量的Length - 1 ,继续循环， 直至存在
             *    5.返回声明变量
             */
            if (strs.Length == 0) return "";
            var prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";
                }
            }
               
            return prefix;
        }
    }
}
