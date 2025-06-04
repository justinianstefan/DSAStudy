using System;

namespace DSAStudy.Core.Algorithms.Arrays
{
    public static class RotateArrayByK
    {
        /// <summary>
        /// Rotates the array to the right by k steps in-place.
        /// </summary>
        /// <param name="nums">The array to rotate</param>
        /// <param name="k">Number of steps to rotate</param>
        public static void Solve(int[]? nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return;
            int n = nums.Length;
            k = k % n;
            if (k == 0) return;

            Reverse(nums, 0, n - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, n - 1);
        }

        private static void Reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            }
        }
    }
} 