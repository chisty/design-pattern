using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ChainOfResponsibility
{
    public class Handlers: AHandler
    {
        public override object Handle(object data)
        {
            Console.WriteLine("Text Handler");
            return base.Handle(data);
        }
    }

    public class XmlHandler : AHandler
    {
        public override object Handle(object data)
        {
            Console.WriteLine("XML Handler");
            return base.Handle(data);
        }
    }

    public class JSONHandler : AHandler
    {
        public override object Handle(object data)
        {
            Console.WriteLine("JSON Handler");
            return base.Handle(data);
        }
    }

    public class MSWordHandler : AHandler
    {
        public override object Handle(object data)
        {
            Console.WriteLine("MSWord Handler");
            return base.Handle(data);
        }
    }
}
