using FizzBuzz.Strategies.Interfaces;

namespace FizzBuzz.Strategies
{
    internal class BuzzStrategy : IFizzBuzz
    {
        public string Doit()
        {
            return "Buzz";
        }
    }
}