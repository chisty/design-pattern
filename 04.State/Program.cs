using System;
using _04.State.States;

namespace _04.State
{
    class Program
    {
        static void Main(string[] args)
        {
            var state = new InitialState();
            var context = new Context(state);

            context.DoWork();
            context.DoWork();
            context.DoWork();

            Console.ReadKey();
        }
    }
}
