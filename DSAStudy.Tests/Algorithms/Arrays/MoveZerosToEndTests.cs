using System;
using Xunit;
using DSAStudy.Core.Algorithms.Arrays;

namespace DSAStudy.Tests.Algorithms.Arrays
{
    public class MoveZerosToEndTests
    {
        [Fact]
        public void BasicCase_MovesZerosCorrectly()
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZerosToEnd.Solve(nums);
            Assert.Equal(new[] { 1, 3, 12, 0, 0 }, nums);
        }

        [Fact]
        public void LeadingZeros_MovesZerosCorrectly()
        {
            int[] nums = { 0, 0, 1 };
            MoveZerosToEnd.Solve(nums);
            Assert.Equal(new[] { 1, 0, 0 }, nums);
        }

        [Fact]
        public void NoZeros_Unchanged()
        {
            int[] nums = { 1, 2, 3 };
            int[] expected = { 1, 2, 3 };
            MoveZerosToEnd.Solve(nums);
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void AllZeros_Unchanged()
        {
            int[] nums = { 0, 0, 0 };
            int[] expected = { 0, 0, 0 };
            MoveZerosToEnd.Solve(nums);
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void EmptyArray_Unchanged()
        {
            int[] nums = Array.Empty<int>();
            MoveZerosToEnd.Solve(nums);
            Assert.Empty(nums);
        }

        [Fact]
        public void NullArray_NoException()
        {
            int[]? nums = null;
            MoveZerosToEnd.Solve(nums);
            Assert.Null(nums);
        }

        [Fact]
        public void SingleElementZero()
        {
            int[] nums = { 0 };
            MoveZerosToEnd.Solve(nums);
            Assert.Equal(new[] { 0 }, nums);
        }

        [Fact]
        public void SingleElementNonZero()
        {
            int[] nums = { 5 };
            MoveZerosToEnd.Solve(nums);
            Assert.Equal(new[] { 5 }, nums);
        }

        [Fact]
        public void Performance_LargeArray()
        {
            int[] nums = new int[100_000];
            for (int i = 0; i < 50_000; i++) nums[i] = 1;
            MoveZerosToEnd.Solve(nums);
            for (int i = 0; i < 50_000; i++) Assert.Equal(1, nums[i]);
            for (int i = 50_000; i < 100_000; i++) Assert.Equal(0, nums[i]);
        }
    }
} 