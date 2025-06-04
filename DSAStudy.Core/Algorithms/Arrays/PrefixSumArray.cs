using System;

namespace DSAStudy.Core.Algorithms.Arrays
{
    public static class PrefixSumArray
    {
        /// <summary>
        /// Creates a prefix sum array where each element at index i is the sum of all elements from index 0 to i.
        /// </summary>
        /// <param name="nums">The input array</param>
        /// <returns>A new array containing the prefix sums</returns>
        public static int[]? Solve(int[]? nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            int[] prefixSums = new int[nums.Length];
            prefixSums[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                prefixSums[i] = prefixSums[i - 1] + nums[i];
            }

            return prefixSums;
        }

        /// <summary>
        /// Gets the sum of elements in the range [start, end] using the prefix sum array.
        /// </summary>
        /// <param name="prefixSums">The prefix sum array</param>
        /// <param name="start">Start index (inclusive)</param>
        /// <param name="end">End index (inclusive)</param>
        /// <returns>The sum of elements in the range [start, end]</returns>
        public static int GetRangeSum(int[]? prefixSums, int start, int end)
        {
            if (prefixSums == null || prefixSums.Length == 0 || start < 0 || end >= prefixSums.Length || start > end)
                return 0;

            return start == 0 ? prefixSums[end] : prefixSums[end] - prefixSums[start - 1];
        }
    }
} 