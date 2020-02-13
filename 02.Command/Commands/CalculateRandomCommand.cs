using System;
using System.Collections.Generic;

namespace _02.Command.Commands
{

    //Complex Command which uses different object to get result
    public class CalculateRandomCommand : ICommand
    {
        private RandomGenerator RandomGenerator { get; set; }
        private readonly int _total;

        public CalculateRandomCommand(RandomGenerator generator, int n)
        {
            RandomGenerator = generator;
            _total = n;
        }
        public void Execute()
        {
            var randoms = RandomGenerator.GetRandomNumbers(_total);
            Console.WriteLine("Generated Random Numbers= "+string.Join(", ", randoms));
        }
    }


    public class RandomGenerator
    {
        public List<int> GetRandomNumbers(int n)
        {
            var random = new Random();
            var list = new List<int>();

            for (var i = 0; i < n; i++)
            {
                list.Add(random.Next());
            }

            return list;
        }
    }
}