using System;
using System.Collections.Generic;

namespace DSAStudy.Core.Algorithms.Arrays
{
    public static class TwoSum
    {
        public static int[] Solve(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                return Array.Empty<int>();
            }

            var seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                
                if (seen.TryGetValue(complement, out int complementIndex))
                {
                    return new[] { complementIndex, i };
                }

                seen[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
} 