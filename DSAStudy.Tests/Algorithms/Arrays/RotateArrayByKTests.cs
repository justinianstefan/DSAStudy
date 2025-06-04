using System;
using Xunit;
using DSAStudy.Core.Algorithms.Arrays;

namespace DSAStudy.Tests.Algorithms.Arrays
{
    public class RotateArrayByKTests
    {
        [Fact]
        public void BasicCase_RotatesCorrectly()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            RotateArrayByK.Solve(nums, 3);
            Assert.Equal(new[] { 5, 6, 7, 1, 2, 3, 4 }, nums);
        }

        [Fact]
        public void KEqualsArrayLength_Unchanged()
        {
            int[] nums = { 1, 2 };
            RotateArrayByK.Solve(nums, 2);
            Assert.Equal(new[] { 1, 2 }, nums);
        }

        [Fact]
        public void KIsZero_Unchanged()
        {
            int[] nums = { 1, 2, 3 };
            RotateArrayByK.Solve(nums, 0);
            Assert.Equal(new[] { 1, 2, 3 }, nums);
        }

        [Fact]
        public void KGreaterThanArrayLength_WrapsCorrectly()
        {
            int[] nums = { 1, 2, 3, 4 };
            RotateArrayByK.Solve(nums, 6);
            Assert.Equal(new[] { 3, 4, 1, 2 }, nums);
        }

        [Fact]
        public void EmptyArray_Unchanged()
        {
            int[] nums = Array.Empty<int>();
            RotateArrayByK.Solve(nums, 3);
            Assert.Empty(nums);
        }

        [Fact]
        public void NullArray_NoException()
        {
            int[]? nums = null;
            RotateArrayByK.Solve(nums, 2);
            Assert.Null(nums);
        }

        [Fact]
        public void SingleElement_Unchanged()
        {
            int[] nums = { 42 };
            RotateArrayByK.Solve(nums, 5);
            Assert.Equal(new[] { 42 }, nums);
        }

        [Fact]
        public void Performance_LargeArray()
        {
            int[] nums = new int[100_000];
            for (int i = 0; i < 100_000; i++) nums[i] = i;
            RotateArrayByK.Solve(nums, 50_000);
            for (int i = 0; i < 50_000; i++) Assert.Equal(i + 50_000, nums[i]);
            for (int i = 50_000; i < 100_000; i++) Assert.Equal(i - 50_000, nums[i]);
        }
    }
} 