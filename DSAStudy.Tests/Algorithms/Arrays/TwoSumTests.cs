using System;
using System.Linq;
using Xunit;
using DSAStudy.Core.Algorithms.Arrays;

namespace DSAStudy.Tests.Algorithms.Arrays
{
    public class TwoSumTests
    {
        [Fact]
        public void BasicCase_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // Act
            int[] result = TwoSum.Solve(nums, target);

            // Assert
            Assert.Equal(new[] { 0, 1 }, result);
        }

        [Fact]
        public void MiddleElements_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 3, 2, 4 };
            int target = 6;

            // Act
            int[] result = TwoSum.Solve(nums, target);

            // Assert
            Assert.Equal(new[] { 1, 2 }, result);
        }

        [Fact]
        public void SameNumbers_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 3, 3 };
            int target = 6;

            // Act
            int[] result = TwoSum.Solve(nums, target);

            // Assert
            Assert.Equal(new[] { 0, 1 }, result);
        }

        [Fact]
        public void MultiplePairs_ReturnsFirstValidPair()
        {
            // Arrange
            int[] nums = { 1, 5, 1, 5 };
            int target = 10;

            // Act
            int[] result = TwoSum.Solve(nums, target);

            // Assert
            Assert.Equal(new[] { 1, 3 }, result);
        }

        [Fact]
        public void NegativeNumbers_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { -1, -2, -3, -4, -5 };
            int target = -8;

            // Act
            int[] result = TwoSum.Solve(nums, target);

            // Assert
            Assert.Equal(new[] { 2, 4 }, result);
        }

        [Fact]
        public void LargeInput_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = new int[100_000];
            nums[99_998] = 1;
            nums[99_999] = 1;
            int target = 2;

            // Act
            int[] result = TwoSum.Solve(nums, target);

            // Assert
            Assert.Equal(new[] { 99_998, 99_999 }, result);
        }

        [Fact]
        public void NoMatch_ReturnsEmptyArray()
        {
            // Arrange
            int[] nums = { 1, 2, 3 };
            int target = 10;

            // Act
            int[] result = TwoSum.Solve(nums, target);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void DuplicateSafe_ReturnsFirstValidPair()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 1 };
            int target = 2;

            // Act
            int[] result = TwoSum.Solve(nums, target);

            // Assert
            Assert.Equal(new[] { 0, 1 }, result);
        }
    }
} 