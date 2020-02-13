using System;
using System.Collections.Generic;

namespace _03.Strategy.Strategies
{
    public class CommaSeparatedStrategy : IStrategy
    {
        public void DoWork(List<int> values)
        {
            Console.WriteLine($"Comma Separated= {string.Join(", ", values)}");
        }
    }
}