using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    class FizzBuzzManagerTests
    {
        [Test]
        public void TheClassic()
        {
            // Arrage
            const long l = 1;
            var manager = new FizzBuzzManager();

            // Act
            var list = manager.DoIt().ToList();

            // Assert
            list.Count().Should().Be(100);
            list[0].Should().Be(l.ToString(CultureInfo.InvariantCulture));
            list[2].Should().Be("Fizz");
            list[4].Should().Be("Buzz");
            list[14].Should().Be("Fizz Buzz");
        }

        [Test]
        public void TheClassicWithCheese()
        {
            // Arrage
            const long l = 1;
            var manager = new FizzBuzzManager();

            // Act
            var list = manager.DoIt(20).ToList();

            // Assert
            list.Count().Should().Be(20);
            list[0].Should().Be(l.ToString(CultureInfo.InvariantCulture));
            list[2].Should().Be("Fizz");
            list[4].Should().Be("Buzz");
            list[14].Should().Be("Fizz Buzz");
        }

        [Test]
        public void TheDeluxeWithEverything()
        {
            // Arrage
            IList configurations = new List<FizzBuzzConfiguration>();
            configurations.Add(new FizzBuzzConfiguration(i => i % 3 == 0, "Fizz"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 5 == 0, "Buzz"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 10 == 0, "10 Fizzy"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 50 == 0, "50 Buzzy"));
            const long l = 1;
            var manager = new FizzBuzzManager();

            // Act
            var list = manager.DoIt(200, (IEnumerable<FizzBuzzConfiguration>)configurations).ToList();

            // Assert
            list.Count().Should().Be(200);
            list[0].Should().Be(l.ToString(CultureInfo.InvariantCulture));
            list[2].Should().Be("Fizz");
            list[4].Should().Be("Buzz");
            list[9].Should().Be("Buzz 10 Fizzy");
            list[14].Should().Be("Fizz Buzz");
            list[19].Should().Be("Buzz 10 Fizzy");
            list[149].Should().Be("Fizz Buzz 10 Fizzy 50 Buzzy");
        }
    }
}
