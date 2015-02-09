using System;

namespace FizzBuzz
{
    public class FizzBuzzConfiguration
    {
        public FizzBuzzConfiguration(Predicate<long> condition, string returnValue)
        {
            Condition = condition;
            ReturnValue = returnValue;
        }

        public Predicate<long> Condition { get; private set; }
        public string ReturnValue { get; private set; }
    }
}
