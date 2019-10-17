using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    static class LeetCode买卖股票的最佳时机1
    {
        /*
         *给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。

        如果你最多只允许完成一笔交易（即买入和卖出一支股票），设计一个算法来计算你所能获取的最大利润。

        注意你不能在买入股票前卖出股票。
        https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/solution/mai-mai-gu-piao-de-zui-jia-shi-ji-by-leetcode/
        解法二 最低谷， 最高分
         */
        public static int MaxProfit(int[] prices)
        {
            var minPrice = int.MaxValue;
            var maxprofit = 0;
            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (maxprofit < prices[i] - minPrice)
                {
                    maxprofit = prices[i] - minPrice;
                }
            }

            return maxprofit;
        }
    }
}
