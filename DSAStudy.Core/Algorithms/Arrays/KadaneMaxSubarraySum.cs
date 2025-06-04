using System;

namespace DSAStudy.Core.Algorithms.Arrays
{
    public static class KadaneMaxSubarraySum
    {
        /// <summary>
        /// Finds the maximum sum of a contiguous subarray using Kadane's algorithm.
        /// </summary>
        /// <param name="nums">The input array</param>
        /// <returns>The maximum sum of a contiguous subarray</returns>
        public static int Solve(int[]? nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int maxSoFar = nums[0];
            int maxEndingHere = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
    }
} 