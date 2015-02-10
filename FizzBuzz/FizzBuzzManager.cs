using System.Collections.Generic;
using FizzBuzz.Factories;

namespace FizzBuzz
{
    public class FizzBuzzManager
    {
        public IEnumerable<string> DoIt(long boundary = 100, IEnumerable<FizzBuzzConfiguration> configurations = null)
        {
            var abstractFactory = new FizzBuzzAbstractFactory();
            var factory = abstractFactory.GetFactory(configurations);
            for (long l = 1; l <= boundary; l++)
            {
                yield return factory.GetStrategy(l).Doit();
            }
        }
    }
}
