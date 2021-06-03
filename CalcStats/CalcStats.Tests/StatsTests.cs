using System;
using FluentAssertions;
using Xunit;

namespace CalcStats.Tests
{
    public class StatsTests
    {
        [Fact]
        public void Minimum_EmptyArray_ArgumentException()
        {
            Action action = () => new Stats().Minimum(new int[0]);
            action.Should().ThrowExactly<ArgumentException>();
        }

        [Fact]
        public void Minimum_NullArray_ArgumentNullException()
        {
            Action action = () => new Stats().Minimum(null);
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(-4, -4)]
        [InlineData(0, 0)]
        [InlineData(int.MaxValue, int.MaxValue)]
        [InlineData(int.MinValue, int.MinValue)]
        public void Minimum_OneElement_FindMinimum(int expected, params int[] array)
        {
            var actualMinimum = new Stats().Minimum(array);
            actualMinimum.Should().Be(expected);
        }

        [Theory]
        [InlineData(0, 1, 9, 9, 8, 4, 3, 0, 4, 6, 5)]
        [InlineData(-8, 1, 9, 9, -8, 0, 3, 0, -8, 6, 5)]
        [InlineData(int.MinValue, int.MaxValue, int.MinValue, int.MaxValue)]
        [InlineData(-1, -1, -1)]
        public void Minimum_Array_FindMinimum(int expected, params int[] array)
        {
            var actualMinimum = new Stats().Minimum(array);
            actualMinimum.Should().Be(expected);
        }

        [Fact]
        public void Maximum_EmptyArray_ArgumentException()
        {
            Action action = () => new Stats().Maximum(new int[0]);
            action.Should().ThrowExactly<ArgumentException>();
        }

        [Fact]
        public void Maximum_NullArray_ArgumentNullException()
        {
            Action action = () => new Stats().Maximum(null);
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(-4, -4)]
        [InlineData(0, 0)]
        [InlineData(int.MaxValue, int.MaxValue)]
        [InlineData(int.MinValue, int.MinValue)]
        public void Maximum_OneElement_FindMaximum(int expected, params int[] array)
        {
            var actualMinimum = new Stats().Maximum(array);
            actualMinimum.Should().Be(expected);
        }

        [Theory]
        [InlineData(9, 1, -9, 9, 8, 4, 3, 0, 4, 6, 5)]
        [InlineData(0, -1, -9, -9, -8, 0, -3, 0, -8, -6, -5)]
        [InlineData(int.MaxValue, int.MaxValue, int.MinValue, int.MaxValue)]
        [InlineData(-1, -1, -1)]
        public void Maximum_Array_FindMaximum(int expected, params int[] array)
        {
            var actualMinimum = new Stats().Maximum(array);
            actualMinimum.Should().Be(expected);
        }

        [Fact]
        public void Length_EmptyArray_ArgumentException()
        {
            Action action = () => new Stats().Length(new int[0]);
            action.Should().ThrowExactly<ArgumentException>();
        }
    }
}
