using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class FindMedian
    {
        public static double SortedArrays(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length + nums2.Length];
            if (nums1.Length == 0)
            {
                nums2.CopyTo(result, 0);
            }
            else if (nums2.Length == 0)
            {
                nums1.CopyTo(result, 0);
            }
            else
            {
                nums1.CopyTo(result, 0);
                nums2.CopyTo(result, nums1.Length);
            }

            Array.Sort(result);

            int index = result.Length / 2;
            if (result.Length % 2 == 0) // Even
            {
                return (result[index] + result[index - 1]) / 2.0;
            }
            else // Odd
            {
                return result[index];
            }
        }
    }
}
