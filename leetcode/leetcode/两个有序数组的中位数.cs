using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    class 两个有序数组的中位数
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return this.FindMedianSortedArrays(nums2, nums1);
            }
            int N = nums1.Length;
            int M = nums2.Length;
            int half = (N + M) / 2;
            int low = 0;
            int high = N;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int t = half - mid;
                int lmax1 = (mid - 1 >= 0) ? nums1[mid - 1] : int.MinValue;
                int rmin1 = (mid < N) ? nums1[mid] : int.MaxValue;
                int lmax2 = (t - 1 >= 0) ? nums2[t - 1] : int.MinValue;
                int rmin2 = (t < M) ? nums2[t] : int.MaxValue;
                if (lmax1 > rmin2)
                {
                    high = mid - 1;
                }
                else if (lmax2 > rmin1)
                {
                    low = mid + 1;
                }
                else
                {
                    low = high = mid;
                    break;
                }
            }
            int u = low;
            int v = half - low;
            int l = max(
                 u - 1 >= 0 ? nums1[u - 1] : int.MaxValue,
                v - 1 >= 0 ? nums2[v - 1] : int.MaxValue);
            int r = min(
                    u < N ? nums1[u] : int.MaxValue,
                    v < M ? nums2[v] : int.MaxValue);
            if ((N + M) % 2 == 1) return r;
            return (l + r) * 1.0 / 2；
        }
    }
}
