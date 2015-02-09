﻿using System;
using System.Collections;
using System.Collections.Generic;
using FizzBuzz;

namespace LetsDoThis
{
    class Program
    {
        static void Main(string[] args)
        {
            IList configurations = new List<FizzBuzzConfiguration>();
            configurations.Add(new FizzBuzzConfiguration(i => i % 3 == 0, "Fizz"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 5 == 0, "Buzz"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 10 == 0, "10 Fizzy"));
            configurations.Add(new FizzBuzzConfiguration(i => i % 50 == 0, "50 Buzzy"));

            var manager = new FizzBuzzManager(configurations as IEnumerable<FizzBuzzConfiguration>);
            var list = manager.DoIt();

            foreach (var value in list)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
