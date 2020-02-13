using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Strategy.Strategies
{
    public class HashSeparatedStrategy: IStrategy
    {
        public void DoWork(List<int> values)
        {
            Console.WriteLine($"Hash Separated= {string.Join("# ", values)}");
        }
    }
}
