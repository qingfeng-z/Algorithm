using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    static class LeetCode买卖股票的最佳时机2
    {
      
        public static int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            for (var i = 0; i < prices.Length-1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    maxProfit += prices[i + 1] - prices[i];
                }
            }

            return maxProfit;
        }
    }
}
