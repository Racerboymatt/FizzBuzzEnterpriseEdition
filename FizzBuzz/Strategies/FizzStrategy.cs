using FizzBuzz.Strategies.Interfaces;

namespace FizzBuzz.Strategies
{
    internal class FizzStrategy : IFizzBuzz
    {
        public string Doit()
        {
            return "Fizz";
        }
    }
}