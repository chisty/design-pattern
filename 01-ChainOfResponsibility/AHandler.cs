using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ChainOfResponsibility
{
    public abstract class AHandler: IHandler
    {
        private IHandler _next;
        

        ////Method 1
        //public IHandler SetNext(IHandler handler)
        //{
        //    _next = handler;
        //    return handler;
        //}




        //Method 2
        public IHandler SetNext(IHandler handler)
        {
            _next = handler;
            return this;
        }

        public virtual object Handle(object data)
        {
            return _next?.Handle(data);
        }
    }
}
