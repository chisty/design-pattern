using System;
using _03.Strategy.Strategies;

namespace _03.Strategy
{
    class Program
    {
        /// <summary>
        /// Command and Strategy are almost same pattern. Both use a context/invoker to call. But the intention is different. Strategy do same or similar thing
        /// using different strategy or technique whereas Command does a single thing depending on payload or intent.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var strategy1 = new CommaSeparatedStrategy();
            var strategy2= new HashSeparatedStrategy();
            var strategy3= new DashSeparatedStrategy();

            var context= new Context(strategy1);
            context.Process();

            context.SetStrategy(strategy2);
            context.Process();

            context.SetStrategy(strategy3);
            context.Process();
        }
    }
}
