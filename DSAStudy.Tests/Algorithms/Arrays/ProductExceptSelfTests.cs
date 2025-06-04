using System;
using Xunit;
using DSAStudy.Core.Algorithms.Arrays;

namespace DSAStudy.Tests.Algorithms.Arrays
{
    public class ProductExceptSelfTests
    {
        [Fact]
        public void BasicCase_ReturnsCorrectProduct()
        {
            int[] nums = { 1, 2, 3, 4 };
            int[]? result = ProductExceptSelf.Solve(nums);
            Assert.NotNull(result);
            Assert.Equal(new[] { 24, 12, 8, 6 }, result);
        }

        [Fact]
        public void ContainsZero_ReturnsCorrectProduct()
        {
            int[] nums = { 1, 2, 0, 4 };
            int[]? result = ProductExceptSelf.Solve(nums);
            Assert.NotNull(result);
            Assert.Equal(new[] { 0, 0, 8, 0 }, result);
        }

        [Fact]
        public void MultipleZeros_ReturnsAllZeros()
        {
            int[] nums = { 0, 2, 0, 4 };
            int[]? result = ProductExceptSelf.Solve(nums);
            Assert.NotNull(result);
            Assert.Equal(new[] { 0, 0, 0, 0 }, result);
        }

        [Fact]
        public void SingleElement_ReturnsOne()
        {
            int[] nums = { 5 };
            int[]? result = ProductExceptSelf.Solve(nums);
            Assert.NotNull(result);
            Assert.Equal(new[] { 1 }, result);
        }

        [Fact]
        public void EmptyArray_ReturnsNull()
        {
            int[] nums = Array.Empty<int>();
            int[]? result = ProductExceptSelf.Solve(nums);
            Assert.Null(result);
        }

        [Fact]
        public void NullArray_ReturnsNull()
        {
            int[]? nums = null;
            int[]? result = ProductExceptSelf.Solve(nums);
            Assert.Null(result);
        }

        [Fact]
        public void Performance_LargeArray()
        {
            int[] nums = new int[100_000];
            for (int i = 0; i < 100_000; i++) nums[i] = 2;
            int[]? result = ProductExceptSelf.Solve(nums);
            Assert.NotNull(result);
            Assert.Equal(100_000, result.Length);
        }
    }
} 