using System;
using Xunit;
using DSAStudy.Core.Algorithms.Arrays;

namespace DSAStudy.Tests.Algorithms.Arrays
{
    public class PrefixSumArrayTests
    {
        [Fact]
        public void BasicCase_ReturnsCorrectPrefixSums()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[]? result = PrefixSumArray.Solve(nums);
            Assert.NotNull(result);
            Assert.Equal(new[] { 1, 3, 6, 10, 15 }, result);
        }

        [Fact]
        public void SingleElement_ReturnsSameElement()
        {
            int[] nums = { 5 };
            int[]? result = PrefixSumArray.Solve(nums);
            Assert.NotNull(result);
            Assert.Equal(new[] { 5 }, result);
        }

        [Fact]
        public void EmptyArray_ReturnsNull()
        {
            int[] nums = Array.Empty<int>();
            int[]? result = PrefixSumArray.Solve(nums);
            Assert.Null(result);
        }

        [Fact]
        public void NullArray_ReturnsNull()
        {
            int[]? nums = null;
            int[]? result = PrefixSumArray.Solve(nums);
            Assert.Null(result);
        }

        [Fact]
        public void GetRangeSum_ValidRange_ReturnsCorrectSum()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[]? prefixSums = PrefixSumArray.Solve(nums);
            Assert.NotNull(prefixSums);
            int sum = PrefixSumArray.GetRangeSum(prefixSums, 1, 3);
            Assert.Equal(9, sum); // 2 + 3 + 4 = 9
        }

        [Fact]
        public void GetRangeSum_StartToEnd_ReturnsTotalSum()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[]? prefixSums = PrefixSumArray.Solve(nums);
            Assert.NotNull(prefixSums);
            int sum = PrefixSumArray.GetRangeSum(prefixSums, 0, 4);
            Assert.Equal(15, sum); // 1 + 2 + 3 + 4 + 5 = 15
        }

        [Fact]
        public void GetRangeSum_InvalidRange_ReturnsZero()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[]? prefixSums = PrefixSumArray.Solve(nums);
            Assert.NotNull(prefixSums);
            int sum = PrefixSumArray.GetRangeSum(prefixSums, 3, 1);
            Assert.Equal(0, sum); // Invalid range (start > end)
        }

        [Fact]
        public void GetRangeSum_NullPrefixSums_ReturnsZero()
        {
            int[]? prefixSums = null;
            int sum = PrefixSumArray.GetRangeSum(prefixSums, 0, 2);
            Assert.Equal(0, sum);
        }

        [Fact]
        public void Performance_LargeArray()
        {
            int[] nums = new int[100_000];
            for (int i = 0; i < 100_000; i++) nums[i] = 1;
            int[]? result = PrefixSumArray.Solve(nums);
            Assert.NotNull(result);
            Assert.Equal(100_000, result[99_999]); // Sum of 100,000 ones
        }
    }
} 