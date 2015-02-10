using System.Collections;
using System.Collections.Generic;
using FizzBuzz.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.UnitTests.StrategyTests
{
    [TestFixture]
    public class DynamicStrategyTests
    {
        [Test]
        public void ShouldReturnSingleResultIfSingleMatchingCondition()
        {
            // Arrange
            IList configurations = new List<FizzBuzzConfiguration>();
            configurations.Add(new FizzBuzzConfiguration(i => i % 3 == 0, "Fizz"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 5 == 0, "Buzz"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 10 == 0, "10 Fizzy"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 50 == 0, "50 Buzzy"));

            const long l = 3;

            // Act
            var strategy = new DynamicStrategy((IEnumerable<FizzBuzzConfiguration>)configurations, l);

            // Assert
            strategy.Doit().Should().Be("Fizz");
        }

        [Test]
        public void ShouldReturnMultipleResultsIfMultipleMatchingCondition()
        {
            // Arrange
            IList configurations = new List<FizzBuzzConfiguration>();
            configurations.Add(new FizzBuzzConfiguration(i => i % 3 == 0, "Fizz"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 5 == 0, "Buzz"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 10 == 0, "10 Fizzy"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 50 == 0, "50 Buzzy"));

            const long l = 15;

            // Act
            var strategy = new DynamicStrategy((IEnumerable<FizzBuzzConfiguration>)configurations, l);

            // Assert
            strategy.Doit().Should().Be("Fizz Buzz");
        }
    }
}