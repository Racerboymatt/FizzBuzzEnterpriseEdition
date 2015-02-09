using FizzBuzz.Factories.Interfaces;
using FizzBuzz.Strategies;
using FizzBuzz.Strategies.Interfaces;

namespace FizzBuzz.Factories
{
    internal class FizzBuzzClassicFactory : IFizzBuzzFactory
    {
        public IFizzBuzz GetStrategy(long i)
        {
            if (i%3 == 0 && i%5 == 0)
            {
                return new FizzBuzzStrategy();
            }
            if (i % 3 == 0)
            {
                return new FizzStrategy();
            }
            if (i % 5 == 0)
            {
                return new BuzzStrategy();
            }
            return new NumberStrategy(i);
        }
    }
}
