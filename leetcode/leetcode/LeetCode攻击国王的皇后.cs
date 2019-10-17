using System;
using System.Collections.Generic;
using System.Linq;
namespace leetcode
{
   static class LeetCode攻击国王的皇后
    {
        public static IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king)
        {
            GetLeft(king[0], king[1], queens);
            // 8个方位
            return null;
        }

        private static int[] GetLeft(int x, int y, int[][] queens)
        {
           var que = queens.Where(q => q[0] == x && q[1] < y);
            return null;
        }

    }
}
