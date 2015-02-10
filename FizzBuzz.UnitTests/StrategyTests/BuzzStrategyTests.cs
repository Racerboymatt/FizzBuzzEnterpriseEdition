using FizzBuzz.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.UnitTests.StrategyTests
{
    [TestFixture]
    public class BuzzStrategyTests
    {
        [Test]
        public void ShouldReturnFizzBuzz()
        {
            // Arrange
            var strategy = new BuzzStrategy();

            // Act Assert
            strategy.Doit().Should().Be("Buzz");
        }
    }
}