using System.Collections;
using System.Collections.Generic;
using FizzBuzz.Factories;
using FizzBuzz.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.UnitTests.FactoryTests
{
    [TestFixture]
    public class FizzBuzzDynamicFactoryTests
    {
        [Test]
        public void ShouldReturnDynamicStrategyForMatchingCondition()
        {
            // Arrange
            IList configurations = new List<FizzBuzzConfiguration>();
            configurations.Add(new FizzBuzzConfiguration(i => i % 3 == 0, "Fizz"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 5 == 0, "Buzz"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 10 == 0, "10 Fizzy"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 50 == 0, "50 Buzzy"));

            var factory = new FizzBuzzDynamicFactory((IEnumerable<FizzBuzzConfiguration>)configurations);

            // Act
            var strategy = factory.GetStrategy(3);

            // Assert
            strategy.Should().BeOfType<DynamicStrategy>();
        }

        [Test]
        public void ShouldReturnNumberStrategyForNonMatchingCondition()
        {
            // Arrange
            IList configurations = new List<FizzBuzzConfiguration>();
            configurations.Add(new FizzBuzzConfiguration(i => i%3 == 0, "Fizz"));
            configurations.Add(new FizzBuzzConfiguration(i => i%5 == 0, "Buzz"));
            configurations.Add(new FizzBuzzConfiguration(i => i%10 == 0, "10 Fizzy"));
            configurations.Add(new FizzBuzzConfiguration(i => i%50 == 0, "50 Buzzy"));

            var factory = new FizzBuzzDynamicFactory((IEnumerable<FizzBuzzConfiguration>) configurations);

            // Act
            var strategy = factory.GetStrategy(2);

            // Assert
            strategy.Should().BeOfType<NumberStrategy>();
        }
    }
}