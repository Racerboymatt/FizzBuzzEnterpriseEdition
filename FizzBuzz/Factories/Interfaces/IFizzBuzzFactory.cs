using FizzBuzz.Strategies.Interfaces;

namespace FizzBuzz.Factories.Interfaces
{
    internal interface IFizzBuzzFactory
    {
        IFizzBuzz GetStrategy(long i);
    }
}