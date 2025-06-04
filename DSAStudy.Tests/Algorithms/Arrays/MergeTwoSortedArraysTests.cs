using System;
using Xunit;
using DSAStudy.Core.Algorithms.Arrays;

namespace DSAStudy.Tests.Algorithms.Arrays
{
    public class MergeTwoSortedArraysTests
    {
        [Fact]
        public void BasicCase_ReturnsMergedArray()
        {
            int[] nums1 = { 1, 3, 5 };
            int[] nums2 = { 2, 4, 6 };
            int[]? result = MergeTwoSortedArrays.Solve(nums1, nums2);
            Assert.NotNull(result);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6 }, result);
        }

        [Fact]
        public void DifferentLengthArrays_ReturnsMergedArray()
        {
            int[] nums1 = { 1, 3, 5, 7 };
            int[] nums2 = { 2, 4 };
            int[]? result = MergeTwoSortedArrays.Solve(nums1, nums2);
            Assert.NotNull(result);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 7 }, result);
        }

        [Fact]
        public void EmptyArrays_ReturnsEmptyArray()
        {
            int[] nums1 = Array.Empty<int>();
            int[] nums2 = Array.Empty<int>();
            int[]? result = MergeTwoSortedArrays.Solve(nums1, nums2);
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void OneEmptyArray_ReturnsOtherArray()
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = Array.Empty<int>();
            int[]? result = MergeTwoSortedArrays.Solve(nums1, nums2);
            Assert.NotNull(result);
            Assert.Equal(nums1, result);
        }

        [Fact]
        public void NullArrays_ReturnsNull()
        {
            int[]? nums1 = null;
            int[]? nums2 = null;
            int[]? result = MergeTwoSortedArrays.Solve(nums1, nums2);
            Assert.Null(result);
        }

        [Fact]
        public void OneNullArray_ReturnsOtherArray()
        {
            int[]? nums1 = null;
            int[] nums2 = { 1, 2, 3 };
            int[]? result = MergeTwoSortedArrays.Solve(nums1, nums2);
            Assert.NotNull(result);
            Assert.Equal(nums2, result);
        }

        [Fact]
        public void DuplicateElements_ReturnsMergedArray()
        {
            int[] nums1 = { 1, 2, 2, 3 };
            int[] nums2 = { 2, 3, 4, 4 };
            int[]? result = MergeTwoSortedArrays.Solve(nums1, nums2);
            Assert.NotNull(result);
            Assert.Equal(new[] { 1, 2, 2, 2, 3, 3, 4, 4 }, result);
        }

        [Fact]
        public void Performance_LargeArrays()
        {
            int[] nums1 = new int[50_000];
            int[] nums2 = new int[50_000];
            for (int i = 0; i < 50_000; i++)
            {
                nums1[i] = i * 2;
                nums2[i] = i * 2 + 1;
            }
            int[]? result = MergeTwoSortedArrays.Solve(nums1, nums2);
            Assert.NotNull(result);
            Assert.Equal(100_000, result.Length);
            for (int i = 0; i < 100_000; i++)
            {
                Assert.Equal(i, result[i]);
            }
        }
    }
} 