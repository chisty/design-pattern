using System;
using System.Collections.Generic;

namespace _03.Strategy.Strategies
{
    public class DashSeparatedStrategy : IStrategy
    {
        public void DoWork(List<int> values)
        {
            Console.WriteLine($"Dash Separated= {string.Join("- ", values)}");
        }
    }
}