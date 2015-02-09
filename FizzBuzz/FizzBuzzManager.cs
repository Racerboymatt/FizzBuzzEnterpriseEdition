using System.Collections.Generic;
using FizzBuzz.Factories;

namespace FizzBuzz
{
    public class FizzBuzzManager
    {
        private readonly IEnumerable<FizzBuzzConfiguration> _configurations;

        public FizzBuzzManager(IEnumerable<FizzBuzzConfiguration> configurations)
        {
            _configurations = configurations;
        }
            
        public IEnumerable<string> DoIt()
        {
            var abstractFactory = new FizzBuzzAbstractFactory();
            var factory = abstractFactory.GetFactory(_configurations);
            for (long l = 1; l <= long.MaxValue; l++)
            {
                yield return factory.GetStrategy(l).Doit();
            }
        }
    }
}
