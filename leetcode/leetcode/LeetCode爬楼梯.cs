﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    static class LeetCode爬楼梯
    {
        public static int ClimbStairs(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
}
