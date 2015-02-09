using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Strategies.Interfaces;

namespace FizzBuzz.Strategies
{
    internal class DynamicStrategy : IFizzBuzz
    {
        private readonly IEnumerable<FizzBuzzConfiguration> _configurations;
        private readonly long _l;

        public DynamicStrategy(IEnumerable<FizzBuzzConfiguration> configurations, long l)
        {
            _configurations = configurations;
            _l = l;
        }

        public string Doit()
        {
            var meetCondition = _configurations.Where(x => x.Condition(_l)).Select(c => c.ReturnValue);
            return string.Join(" ", meetCondition);
        }
    }
}