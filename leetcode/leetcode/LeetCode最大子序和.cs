using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    static class LeetCode最大子序和
    {
        /*
         * 假设你是一个选择性遗忘的赌徒，数组表示你这几天来赢钱或者输钱，
            你用sum来表示这几天来的输赢，
            用ans来存储你手里赢到的最多的钱，
            如果昨天你手上还是输钱（sum < 0），你忘记它，明天继续赌钱；
            如果你手上是赢钱(sum > 0), 你记得，你继续赌钱；
            你记得你手气最好的时候
         * */
        public static int MaxSubArray(int[] nums)
        {
            int ans = nums[0];
            int sum = 0;
            foreach (var num in nums)
            {
                if (sum > 0)
                {
                    sum += num;
                }
                else
                {
                    sum = num;
                }
                ans = Math.Max(ans, sum);
            }
            return ans;
           
        }
    }
}
