using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object data);
        
    }

}
