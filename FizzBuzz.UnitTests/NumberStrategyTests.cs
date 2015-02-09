using System.Globalization;
using FizzBuzz.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class NumberStrategyTests
    {
        [Test]
        public void ShouldReturnNumberWhenPassedInt()
        {
            const long l = 12121;
            var strategy = new NumberStrategy(l);
            strategy.Doit().Should().Be(l.ToString(CultureInfo.InvariantCulture));
        }
    }
}
