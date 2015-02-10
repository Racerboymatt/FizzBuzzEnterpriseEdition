using System.Globalization;
using FizzBuzz.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.UnitTests.StrategyTests
{
    [TestFixture]
    public class NumberStrategyTests
    {
        [Test]
        public void ShouldReturnNumberWhenPassedInt()
        {
            // Arrange
            const long l = 12121;
            var strategy = new NumberStrategy(l);

            // Act Assert
            strategy.Doit().Should().Be(l.ToString(CultureInfo.InvariantCulture));
        }
    }
}
