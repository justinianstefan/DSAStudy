using System;

namespace DSAStudy.Core.Algorithms.Arrays
{
    public static class FindDuplicateNumber
    {
        /// <summary>
        /// Finds the duplicate number in an array where numbers are in the range [1, n] and there is exactly one duplicate.
        /// Uses Floyd's Cycle-Finding Algorithm (Tortoise and Hare).
        /// </summary>
        /// <param name="nums">Array containing numbers from 1 to n with one duplicate</param>
        /// <returns>The duplicate number, or -1 if input is invalid</returns>
        public static int Solve(int[]? nums)
        {
            if (nums == null || nums.Length <= 1)
                return -1;

            // Floyd's Cycle-Finding Algorithm
            int slow = nums[0];
            int fast = nums[0];

            // Find the intersection point of the two runners
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);

            // Find the entrance to the cycle
            slow = nums[0];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return slow;
        }

        /// <summary>
        /// Finds the duplicate number using the sum approach.
        /// Note: This method can overflow with large numbers.
        /// </summary>
        /// <param name="nums">Array containing numbers from 1 to n with one duplicate</param>
        /// <returns>The duplicate number, or -1 if input is invalid</returns>
        public static int SolveWithSum(int[]? nums)
        {
            if (nums == null || nums.Length <= 1)
                return -1;

            int n = nums.Length - 1;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int num in nums)
            {
                actualSum += num;
            }

            return actualSum - expectedSum;
        }
    }
} 