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
    }
}
