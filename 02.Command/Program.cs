using System;
using _02.Command.Commands;

namespace _02.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var helloCommand = new HelloCommand("Hello Command");
            var countCommand= new CountCommand(10);
            var complexCommand= new CalculateRandomCommand(new RandomGenerator(), 5);

            var invoker= new Invoker();
            invoker.Command = helloCommand;
            invoker.DoWork();

            invoker.Command = countCommand;
            invoker.DoWork();

            invoker.Command = complexCommand;
            invoker.DoWork();


            Console.ReadKey();
        }
    }
}
