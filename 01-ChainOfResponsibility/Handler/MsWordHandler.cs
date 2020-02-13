using System;

namespace _01_ChainOfResponsibility.Handler
{
    public class MsWordHandler : AHandler
    {
        public override object Handle(object data)
        {
            Console.WriteLine("MSWord Handler");
            return base.Handle(data);
        }
    }
}