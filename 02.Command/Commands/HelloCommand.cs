using System;

namespace _02.Command.Commands
{
    public class HelloCommand : ICommand
    {
        private readonly string _helloText;

        public HelloCommand(string text)
        {
            _helloText = text;
        }
        public void Execute()
        {
            Console.WriteLine(_helloText);
        }
    }
}