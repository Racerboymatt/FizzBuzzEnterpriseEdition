using System.Globalization;
using FizzBuzz.Strategies.Interfaces;

namespace FizzBuzz.Strategies
{
    internal class NumberStrategy : IFizzBuzz
    {
        private readonly long _l;

        public NumberStrategy(long l)
        {
            _l = l;
        }

        public string Doit()
        {
            return _l.ToString(CultureInfo.InvariantCulture);
        }
    }
}