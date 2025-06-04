using System;

namespace DSAStudy.Core.Algorithms.Arrays
{
    public static class ProductExceptSelf
    {
        /// <summary>
        /// Returns an array where each element is the product of all elements in the input array except for the element at that index.
        /// Does not use division and runs in O(n) time.
        /// </summary>
        /// <param name="nums">The input array</param>
        /// <returns>The product array, or null if input is null or empty</returns>
        public static int[]? Solve(int[]? nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            int n = nums.Length;
            int[] result = new int[n];

            // Calculate prefix products
            int prefix = 1;
            for (int i = 0; i < n; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            // Calculate suffix products and multiply
            int suffix = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] *= suffix;
                suffix *= nums[i];
            }

            return result;
        }
    }
} 