using System;

namespace DSAStudy.Core.Algorithms.Arrays
{
    public static class FindMissingNumber
    {
        /// <summary>
        /// Finds the missing number in a sequence of numbers from 0 to n.
        /// </summary>
        /// <param name="nums">Array containing numbers from 0 to n with one number missing</param>
        /// <returns>The missing number, or -1 if input is invalid</returns>
        public static int Solve(int[]? nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            // Using the sum formula: sum of numbers from 0 to n = n * (n + 1) / 2
            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int num in nums)
            {
                actualSum += num;
            }

            return expectedSum - actualSum;
        }

        /// <summary>
        /// Finds the missing number using XOR operation.
        /// This method is more efficient for large numbers as it avoids integer overflow.
        /// </summary>
        /// <param name="nums">Array containing numbers from 0 to n with one number missing</param>
        /// <returns>The missing number, or -1 if input is invalid</returns>
        public static int SolveWithXor(int[]? nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int result = nums.Length; // Start with n

            for (int i = 0; i < nums.Length; i++)
            {
                result ^= i ^ nums[i];
            }

            return result;
        }
    }
} 