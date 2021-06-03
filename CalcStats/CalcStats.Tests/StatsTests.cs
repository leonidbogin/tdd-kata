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


    }
}
