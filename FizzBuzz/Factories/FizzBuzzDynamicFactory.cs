using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Factories.Interfaces;
using FizzBuzz.Strategies;
using FizzBuzz.Strategies.Interfaces;

namespace FizzBuzz.Factories
{
    internal class FizzBuzzDynamicFactory : IFizzBuzzFactory
    {
        private readonly IEnumerable<FizzBuzzConfiguration> _configurations;

        public FizzBuzzDynamicFactory(IEnumerable<FizzBuzzConfiguration> configurations)
        {
            _configurations = configurations;
        }

        public IFizzBuzz GetStrategy(long l)
        {
            if (_configurations.Select(x => x.Condition(l)).Any(c => c))
            {
                return new DynamicStrategy(_configurations, l);
            }
            return new NumberStrategy(l);
        }
    }
}