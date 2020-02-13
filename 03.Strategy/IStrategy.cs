using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Strategy
{
    public interface IStrategy
    {
        void DoWork(List<int> values);
    }
}
