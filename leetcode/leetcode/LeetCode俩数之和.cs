using System;
using System.Collections.Generic;

namespace leetcode
{
    class LeetCode俩数之和
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // 运用字典 log（n）
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var num = target - nums[i];
                if (dict.ContainsKey(num))
                {
                    return new int[] { dict[num], i };
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return null;
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            // 暴力解决方法
            for (int i = 0; i < nums.Length; i++)
            {
                var num = target - nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == num && i != j)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;
        }

    }
}
