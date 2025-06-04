using System;

namespace DSAStudy.Core.Algorithms.Arrays
{
    public static class RemoveDuplicatesFromSortedArray
    {
        /// <summary>
        /// Removes duplicates from a sorted array in-place and returns the new length.
        /// </summary>
        /// <param name="nums">The sorted array with duplicates</param>
        /// <returns>The length of the array after removing duplicates</returns>
        public static int Solve(int[]? nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int writeIndex = 1;
            for (int readIndex = 1; readIndex < nums.Length; readIndex++)
            {
                if (nums[readIndex] != nums[writeIndex - 1])
                {
                    nums[writeIndex] = nums[readIndex];
                    writeIndex++;
                }
            }

            return writeIndex;
        }
    }
} 