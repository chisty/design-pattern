using System;

namespace _01_ChainOfResponsibility.Handler
{
    public class JsonHandler : AHandler
    {
        public override object Handle(object data)
        {
            Console.WriteLine("JSON Handler");
            return base.Handle(data);
        }
    }
}