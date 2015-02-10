using FizzBuzz.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.UnitTests.StrategyTests
{
    [TestFixture]
    public class FizzBuzzStrategyTests
    {
        [Test]
        public void ShouldReturnFizzBuzz()
        {
            // Arrange
            var strategy = new FizzBuzzStrategy();

            // Act Assert
            strategy.Doit().Should().Be("Fizz Buzz");
        }
    }
}