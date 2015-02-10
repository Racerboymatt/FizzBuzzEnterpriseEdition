using FizzBuzz.Factories;
using FizzBuzz.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.UnitTests.FactoryTests
{
    [TestFixture]
    public class FizzBuzzClassicFactoryTests
    {
        [Test]
        public void ShouldReturnFizzStrategyFor3()
        {
            // Arrange
            var factory = new FizzBuzzClassicFactory();

            // Act
            var strategy = factory.GetStrategy(3);

            // Assert
            strategy.Should().BeOfType<FizzStrategy>();
        }

        [Test]
        public void ShouldReturnBuzzStrategyFor5()
        {
            // Arrange
            var factory = new FizzBuzzClassicFactory();

            // Act
            var strategy = factory.GetStrategy(5);

            // Assert
            strategy.Should().BeOfType<BuzzStrategy>();
        }

        [Test]
        public void ShouldReturnFizzBuzzStrategyFor15()
        {
            // Arrange
            var factory = new FizzBuzzClassicFactory();

            // Act
            var strategy = factory.GetStrategy(15);

            // Assert
            strategy.Should().BeOfType<FizzBuzzStrategy>();
        }

        [Test]
        public void ShouldReturnFizzBuzzStrategyFor2()
        {
            // Arrange
            var factory = new FizzBuzzClassicFactory();

            // Act
            var strategy = factory.GetStrategy(2);

            // Assert
            strategy.Should().BeOfType<NumberStrategy>();
        }
    }
}