using System;
using Xunit;
using DSAStudy.Core.Algorithms.Arrays;

namespace DSAStudy.Tests.Algorithms.Arrays
{
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [Fact]
        public void BasicCase_ReturnsCorrectLength()
        {
            // Arrange
            int[] nums = { 1, 1, 2 };

            // Act
            int result = RemoveDuplicatesFromSortedArray.Solve(nums);

            // Assert
            Assert.Equal(2, result);
            Assert.Equal(1, nums[0]);
            Assert.Equal(2, nums[1]);
        }

        [Fact]
        public void MultipleDuplicates_ReturnsCorrectLength()
        {
            // Arrange
            int[] nums = { 1, 2, 2, 3, 4, 4, 5 };

            // Act
            int result = RemoveDuplicatesFromSortedArray.Solve(nums);

            // Assert
            Assert.Equal(5, result);
            Assert.Equal(1, nums[0]);
            Assert.Equal(2, nums[1]);
            Assert.Equal(3, nums[2]);
            Assert.Equal(4, nums[3]);
            Assert.Equal(5, nums[4]);
        }

        [Fact]
        public void EmptyArray_ReturnsZero()
        {
            // Arrange
            int[] nums = Array.Empty<int>();

            // Act
            int result = RemoveDuplicatesFromSortedArray.Solve(nums);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void AllElementsSame_ReturnsOne()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 1, 1 };

            // Act
            int result = RemoveDuplicatesFromSortedArray.Solve(nums);

            // Assert
            Assert.Equal(1, result);
            Assert.Equal(1, nums[0]);
        }

        [Fact]
        public void NullArray_ReturnsZero()
        {
            // Arrange
            int[]? nums = null;

            // Act
            int result = RemoveDuplicatesFromSortedArray.Solve(nums!);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void SingleElement_ReturnsOne()
        {
            // Arrange
            int[] nums = { 1 };

            // Act
            int result = RemoveDuplicatesFromSortedArray.Solve(nums);

            // Assert
            Assert.Equal(1, result);
            Assert.Equal(1, nums[0]);
        }
    }
} 