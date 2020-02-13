using System;

namespace _02.Command.Commands
{
    public class CountCommand : ICommand
    {
        private readonly int _totalCount;

        public CountCommand(int n)
        {
            _totalCount = n;
        }
        public void Execute()
        {
            Console.Write("Counting= ");
            for (var i = 0; i <= _totalCount; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\nCount complete.");
        }
    }
}