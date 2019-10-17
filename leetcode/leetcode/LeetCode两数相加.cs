using System;
using System.Collections.Generic;

namespace leetcode
{
    class LeetCode两数相加
    {
        //无重复字符的最长子串

        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            var set = new HashSet<char>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }
            return ans;
        }
    }
}
