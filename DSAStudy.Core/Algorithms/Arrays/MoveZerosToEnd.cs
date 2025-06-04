using System;

namespace DSAStudy.Core.Algorithms.Arrays
{
    public static class MoveZerosToEnd
    {
        /// <summary>
        /// Moves all zeros in the array to the end while maintaining the order of non-zero elements.
        /// </summary>
        /// <param name="nums">The array to modify in-place</param>
        public static void Solve(int[]? nums)
        {
            if (nums == null || nums.Length == 0)
                return;

            int insertPos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[insertPos++] = nums[i];
                }
            }
            while (insertPos < nums.Length)
            {
                nums[insertPos++] = 0;
            }
        }
    }
} 