using System;
using Xunit;
using DSAStudy.Core.Algorithms.Arrays;

namespace DSAStudy.Tests.Algorithms.Arrays
{
    public class FindMissingNumberTests
    {
        [Fact]
        public void BasicCase_ReturnsMissingNumber()
        {
            int[] nums = { 0, 1, 3 };
            int result = FindMissingNumber.Solve(nums);
            Assert.Equal(2, result);
        }

        [Fact]
        public void MissingZero_ReturnsZero()
        {
            int[] nums = { 1, 2, 3 };
            int result = FindMissingNumber.Solve(nums);
            Assert.Equal(0, result);
        }

        [Fact]
        public void MissingLastNumber_ReturnsLastNumber()
        {
            int[] nums = { 0, 1, 2, 3 };
            int result = FindMissingNumber.Solve(nums);
            Assert.Equal(4, result);
        }

        [Fact]
        public void EmptyArray_ReturnsNegativeOne()
        {
            int[] nums = Array.Empty<int>();
            int result = FindMissingNumber.Solve(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void NullArray_ReturnsNegativeOne()
        {
            int[]? nums = null;
            int result = FindMissingNumber.Solve(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Performance_LargeArray()
        {
            int[] nums = new int[100_000];
            for (int i = 0; i < 100_000; i++)
            {
                nums[i] = i < 50_000 ? i : i + 1; // Missing number is 50,000
            }
            int result = FindMissingNumber.Solve(nums);
            Assert.Equal(50_000, result);
        }

        [Fact]
        public void SolveWithXor_BasicCase_ReturnsMissingNumber()
        {
            int[] nums = { 0, 1, 3 };
            int result = FindMissingNumber.SolveWithXor(nums);
            Assert.Equal(2, result);
        }

        [Fact]
        public void SolveWithXor_MissingZero_ReturnsZero()
        {
            int[] nums = { 1, 2, 3 };
            int result = FindMissingNumber.SolveWithXor(nums);
            Assert.Equal(0, result);
        }

        [Fact]
        public void SolveWithXor_MissingLastNumber_ReturnsLastNumber()
        {
            int[] nums = { 0, 1, 2, 3 };
            int result = FindMissingNumber.SolveWithXor(nums);
            Assert.Equal(4, result);
        }

        [Fact]
        public void SolveWithXor_EmptyArray_ReturnsNegativeOne()
        {
            int[] nums = Array.Empty<int>();
            int result = FindMissingNumber.SolveWithXor(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void SolveWithXor_NullArray_ReturnsNegativeOne()
        {
            int[]? nums = null;
            int result = FindMissingNumber.SolveWithXor(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void SolveWithXor_Performance_LargeArray()
        {
            int[] nums = new int[100_000];
            for (int i = 0; i < 100_000; i++)
            {
                nums[i] = i < 50_000 ? i : i + 1; // Missing number is 50,000
            }
            int result = FindMissingNumber.SolveWithXor(nums);
            Assert.Equal(50_000, result);
        }
    }
} 