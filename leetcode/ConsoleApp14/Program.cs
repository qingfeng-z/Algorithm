using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp14
{
    /*
     * 给定一个元素都是正整数的数组A ，正整数 L 以及 R (L <= R)。

       求连续、非空且其中最大元素满足大于等于L 小于等于R的子数组个数。
       
       例如 :
       输入: 
       A = [2, 1, 4, 3, 2]
       L = 2
       R = 3
       输出: 3
       解释: 满足条件的子数组: [2], [2, 1], [3].
       注意:
       
       L, R  和 A[i] 都是整数，范围在 [0, 10^9]。
       数组 A 的长度范围在[1, 50000]。
     */
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Console.WriteLine("Hello World!");
                int[] arr = new[] { 1, 10, 10, 2, 5, 2, 1 };
                //var a = CanPartition(arr);
                //Console.WriteLine(a);
                Console.ReadKey();
            }
        }

        private static long GetArray(int[] A, long L, long R)
        {
            int num = 0;
            int count = 0;

            int l = 0, gap = -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > R)
                {
                    l = i + 1;
                    gap = -1;
                }
                else if (A[i] < L)
                {
                    if (gap >= l)
                        count += gap - l + 1;
                }
                else
                {
                    gap = i;
                    count += gap - l + 1;
                }
            }

            return count;
        }

        //public static int CanPartition(int[] nums)
        //{
        //    var num = nums.Sum();
        //}


        /*
         * 给定一个链表和一个特定值 x，对链表进行分隔，使得所有小于 x 的节点都在大于或等于 x 的节点之前。

        你应当保留两个分区中每个节点的初始相对位置。
        
        示例:
        
        输入: head = 1->4->3->2->5->2, x = 3
        输出: 1->2->2->4->3->5
         */
        public ListNode Partition(ListNode head, int x)
        {
            var que= new Queue<long>();


            return null;
        }
    }

    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
}
