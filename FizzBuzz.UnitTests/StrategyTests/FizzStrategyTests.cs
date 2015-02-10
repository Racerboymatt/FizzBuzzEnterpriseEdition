using FizzBuzz.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.UnitTests.StrategyTests
{
    [TestFixture]
    public class FizzStrategyTests
    {
        [Test]
        public void ShouldReturnFizzBuzz()
        {
            // Arragne
            var strategy = new FizzStrategy();

            // Act Assert
            strategy.Doit().Should().Be("Fizz");
        }
    }
}