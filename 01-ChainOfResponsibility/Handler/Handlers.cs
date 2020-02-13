using System;

namespace _01_ChainOfResponsibility.Handler
{
    public class Handlers: AHandler
    {
        public override object Handle(object data)
        {
            Console.WriteLine("Text Handler");
            return base.Handle(data);
        }
    }
}
