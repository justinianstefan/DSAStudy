using System;
using Xunit;
using DSAStudy.Core.Algorithms.Arrays;

namespace DSAStudy.Tests.Algorithms.Arrays
{
    public class FindDuplicateNumberTests
    {
        [Fact]
        public void BasicCase_ReturnsDuplicateNumber()
        {
            int[] nums = { 1, 3, 4, 2, 2 };
            int result = FindDuplicateNumber.Solve(nums);
            Assert.Equal(2, result);
        }

        [Fact]
        public void DuplicateAtStart_ReturnsDuplicateNumber()
        {
            int[] nums = { 3, 1, 3, 4, 2 };
            int result = FindDuplicateNumber.Solve(nums);
            Assert.Equal(3, result);
        }

        [Fact]
        public void DuplicateAtEnd_ReturnsDuplicateNumber()
        {
            int[] nums = { 1, 2, 3, 4, 4 };
            int result = FindDuplicateNumber.Solve(nums);
            Assert.Equal(4, result);
        }

        [Fact]
        public void EmptyArray_ReturnsNegativeOne()
        {
            int[] nums = Array.Empty<int>();
            int result = FindDuplicateNumber.Solve(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void NullArray_ReturnsNegativeOne()
        {
            int[]? nums = null;
            int result = FindDuplicateNumber.Solve(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void SingleElement_ReturnsNegativeOne()
        {
            int[] nums = { 1 };
            int result = FindDuplicateNumber.Solve(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Performance_LargeArray()
        {
            int[] nums = new int[100_001];
            for (int i = 0; i < 100_000; i++)
            {
                nums[i] = i + 1;
            }
            nums[100_000] = 50_000; // Duplicate number is 50,000
            int result = FindDuplicateNumber.Solve(nums);
            Assert.Equal(50_000, result);
        }

        [Fact]
        public void SolveWithSum_BasicCase_ReturnsDuplicateNumber()
        {
            int[] nums = { 1, 3, 4, 2, 2 };
            int result = FindDuplicateNumber.SolveWithSum(nums);
            Assert.Equal(2, result);
        }

        [Fact]
        public void SolveWithSum_DuplicateAtStart_ReturnsDuplicateNumber()
        {
            int[] nums = { 3, 1, 3, 4, 2 };
            int result = FindDuplicateNumber.SolveWithSum(nums);
            Assert.Equal(3, result);
        }

        [Fact]
        public void SolveWithSum_DuplicateAtEnd_ReturnsDuplicateNumber()
        {
            int[] nums = { 1, 2, 3, 4, 4 };
            int result = FindDuplicateNumber.SolveWithSum(nums);
            Assert.Equal(4, result);
        }

        [Fact]
        public void SolveWithSum_EmptyArray_ReturnsNegativeOne()
        {
            int[] nums = Array.Empty<int>();
            int result = FindDuplicateNumber.SolveWithSum(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void SolveWithSum_NullArray_ReturnsNegativeOne()
        {
            int[]? nums = null;
            int result = FindDuplicateNumber.SolveWithSum(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void SolveWithSum_SingleElement_ReturnsNegativeOne()
        {
            int[] nums = { 1 };
            int result = FindDuplicateNumber.SolveWithSum(nums);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void SolveWithSum_Performance_LargeArray()
        {
            int[] nums = new int[100_001];
            for (int i = 0; i < 100_000; i++)
            {
                nums[i] = i + 1;
            }
            nums[100_000] = 50_000; // Duplicate number is 50,000
            int result = FindDuplicateNumber.SolveWithSum(nums);
            Assert.Equal(50_000, result);
        }
    }
} 