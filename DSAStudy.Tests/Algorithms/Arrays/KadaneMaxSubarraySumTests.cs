using System;
using Xunit;
using DSAStudy.Core.Algorithms.Arrays;

namespace DSAStudy.Tests.Algorithms.Arrays
{
    public class KadaneMaxSubarraySumTests
    {
        [Fact]
        public void BasicCase_ReturnsCorrectSum()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = KadaneMaxSubarraySum.Solve(nums);
            Assert.Equal(6, result);
        }

        [Fact]
        public void SingleElement_ReturnsElement()
        {
            int[] nums = { 1 };
            int result = KadaneMaxSubarraySum.Solve(nums);
            Assert.Equal(1, result);
        }

        [Fact]
        public void AllNegative_ReturnsLargestNegative()
        {
            int[] nums = { -1, -2, -3 };
            int result = KadaneMaxSubarraySum.Solve(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void AllPositive_ReturnsSumOfAll()
        {
            int[] nums = { 5, 4, -1, 7, 8 };
            int result = KadaneMaxSubarraySum.Solve(nums);
            Assert.Equal(23, result);
        }

        [Fact]
        public void EmptyArray_ReturnsZero()
        {
            int[] nums = Array.Empty<int>();
            int result = KadaneMaxSubarraySum.Solve(nums);
            Assert.Equal(0, result);
        }

        [Fact]
        public void NullArray_ReturnsZero()
        {
            int[]? nums = null;
            int result = KadaneMaxSubarraySum.Solve(nums);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Performance_LargeArray()
        {
            int[] nums = new int[100_000];
            for (int i = 0; i < 100_000; i++) nums[i] = i % 2 == 0 ? 1 : -1;
            int result = KadaneMaxSubarraySum.Solve(nums);
            Assert.Equal(1, result);
        }
    }
} 