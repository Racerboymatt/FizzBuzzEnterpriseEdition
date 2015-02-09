using System.Collections.Generic;

namespace FizzBuzz.Factories.Interfaces
{
    internal interface IFizzBuzzAbstractFactory
    {
        IFizzBuzzFactory GetFactory(IEnumerable<FizzBuzzConfiguration> configurations);
    }
}