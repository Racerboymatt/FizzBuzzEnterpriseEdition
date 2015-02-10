using System.Collections;
using System.Collections.Generic;
using FizzBuzz.Factories;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.UnitTests.FactoryTests
{
    [TestFixture]
    public class FizzBuzzAbstractFactoryTests
    {
        [Test]
        public void ShouldReturnDynamicStrategyForMatchingCondition()
        {
            // Arrange
            IList configurations = new List<FizzBuzzConfiguration>();
            configurations.Add(new FizzBuzzConfiguration(i => i % 3 == 0, "Fizz"));
            var factory = new FizzBuzzAbstractFactory();

            // Act
            var strategy = factory.GetFactory((IEnumerable<FizzBuzzConfiguration>)configurations);

            // Assert
            strategy.Should().BeOfType<FizzBuzzDynamicFactory>();
        }

        [Test]
        public void ShouldReturnNumberStrategyForNonMatchingCondition()
        {
            // Arrange
            var factory = new FizzBuzzAbstractFactory();

            // Act
            var strategy = factory.GetFactory(null);

            // Assert
            strategy.Should().BeOfType<FizzBuzzClassicFactory>();
        }
    }
}