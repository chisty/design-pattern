using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Strategy
{
    //Strategies are invoked by a context. client will not call directly.
    public class Context
    {
        private IStrategy _strategy;
        public Context()
        {
        }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }


        public void Process()
        {
            Console.WriteLine("Context is working with some data");
            var list = GenerateList();
            _strategy.DoWork(list);
            Console.WriteLine("Process complete");
        }


        private List<int> GenerateList()
        {
            var list = new List<int>();
            for (int i = 10; i < 101; i += 10)
            {
                list.Add(i);
            }

            return list;
        }
    }
}
