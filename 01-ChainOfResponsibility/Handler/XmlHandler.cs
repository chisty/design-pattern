using System;

namespace _01_ChainOfResponsibility.Handler
{
    public class XmlHandler : AHandler
    {
        public override object Handle(object data)
        {
            Console.WriteLine("XML Handler");
            return base.Handle(data);
        }
    }
}