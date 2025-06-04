using System;

namespace DSAStudy.Core.Algorithms.Arrays
{
    public static class MergeTwoSortedArrays
    {
        /// <summary>
        /// Merges two sorted arrays into a single sorted array.
        /// </summary>
        /// <param name="nums1">First sorted array</param>
        /// <param name="nums2">Second sorted array</param>
        /// <returns>A new array containing all elements from both arrays in sorted order</returns>
        public static int[]? Solve(int[]? nums1, int[]? nums2)
        {
            if (nums1 == null && nums2 == null)
                return null;
            if (nums1 == null)
                return nums2;
            if (nums2 == null)
                return nums1;

            int[] result = new int[nums1.Length + nums2.Length];
            int i = 0, j = 0, k = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] <= nums2[j])
                {
                    result[k++] = nums1[i++];
                }
                else
                {
                    result[k++] = nums2[j++];
                }
            }

            // Copy remaining elements from nums1, if any
            while (i < nums1.Length)
            {
                result[k++] = nums1[i++];
            }

            // Copy remaining elements from nums2, if any
            while (j < nums2.Length)
            {
                result[k++] = nums2[j++];
            }

            return result;
        }
    }
} 