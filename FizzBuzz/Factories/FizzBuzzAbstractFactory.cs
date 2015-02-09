using System.Collections.Generic;
using FizzBuzz.Factories.Interfaces;

namespace FizzBuzz.Factories
{
    internal class FizzBuzzAbstractFactory
    {
        internal IFizzBuzzFactory GetFactory(IEnumerable<FizzBuzzConfiguration> configurations)
        {
            if (configurations != null)
            {
                return new FizzBuzzDynamicFactory(configurations);
            }
            return new FizzBuzzClassicFactory();
        }
    }
}
