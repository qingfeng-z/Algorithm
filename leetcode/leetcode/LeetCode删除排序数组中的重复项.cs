using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    static class LeetCode删除排序数组中的重复项
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;
            var j = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[j] != nums[i]) {
                    nums[++j] = nums[i];
                }
            }   

            return ++j;
        }
    }
}
