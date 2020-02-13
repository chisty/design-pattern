using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Command
{
    //Invoker will invoke commands and it will be set up by the client. Client will not call the commands. Invoker will execute them according to client's wish
    public class Invoker
    {
        public ICommand Command { get; set; }


        public void DoWork()
        {
            Console.WriteLine("Executing Command from Invoker =>");
            Command.Execute();
            Console.WriteLine("Process complete\n");
        }
    }
}
