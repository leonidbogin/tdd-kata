using System;
using FluentAssertions;
using Xunit;

namespace CalcStats.Tests
{
    public class StatsTests
    {
        [Fact]
        public void Minimum_NullArray_ArgumentNullException()
        {
            Action action = () => new Stats().Minimum(null);
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Fact]
        public void Minimum_EmptyArray_ArgumentException()
        {
            Action action = () => new Stats().Minimum(new int[0]);
            action.Should().ThrowExactly<ArgumentException>();
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
        public void Maximum_NullArray_ArgumentNullException()
        {
            Action action = () => new Stats().Maximum(null);
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Fact]
        public void Maximum_EmptyArray_ArgumentException()
        {
            Action action = () => new Stats().Maximum(new int[0]);
            action.Should().ThrowExactly<ArgumentException>();
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
        public void Length_NullArray_ArgumentNullException()
        {
            Action action = () => new Stats().Length(null);
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Fact]
        public void Length_EmptyArray_0()
        {
            var actualMinimum = new Stats().Length(new int[0]);
            actualMinimum.Should().Be(0);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-4)]
        [InlineData(0)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void Length_OneElement_1(params int[] array)
        {
            var actualMinimum = new Stats().Length(array);
            actualMinimum.Should().Be(1);
        }

        [Theory]
        [InlineData(10, 1, -9, 9, 8, 4, 3, 0, 4, 6, 5)]
        [InlineData(3, int.MaxValue, int.MinValue, int.MaxValue)]
        public void Length_Array_CalcLength(int expected, params int[] array)
        {
            var actualMinimum = new Stats().Length(array);
            actualMinimum.Should().Be(expected);
        }

        [Fact]
        public void Average_NullArray_ArgumentNullException()
        {
            Action action = () => new Stats().Average(null);
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Fact]
        public void Average_EmptyArray_ArgumentException()
        {
            Action action = () => new Stats().Average(new int[0]);
            action.Should().ThrowExactly<ArgumentException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(-4, -4)]
        [InlineData(0, 0)]
        [InlineData(int.MaxValue, int.MaxValue)]
        [InlineData(int.MinValue, int.MinValue)]
        public void Average_OneElement_CalcAverage(int expected, params int[] array)
        {
            var actualMinimum = new Stats().Average(array);
            actualMinimum.Should().Be(expected);
        }

        [Theory]
        [InlineData(3.1, 1, -9, 9, 8, 4, 3, 0, 4, 6, 5)]
        [InlineData(-4.9, -1, -9, -9, -8, 0, -3, 0, -8, -6, -5)]
        [InlineData(-0.5, int.MinValue, int.MaxValue)]
        [InlineData(-1, -1, -1)]
        public void Average_Array_FindMaximum(double expected, params int[] array)
        {
            var actualMinimum = new Stats().Average(array);
            actualMinimum.Should().Be(expected);
        }
    }
}
