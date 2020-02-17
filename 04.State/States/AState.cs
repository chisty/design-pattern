using System;
using System.Collections.Generic;
using System.Text;

namespace _04.State.States
{
    public abstract class AState : IState
    {
        protected Context Context { get; set; }

        public void SetContext(Context context)
        {
            Context = context;
        }

        public abstract void DoWork();
        public abstract void Save();
    }
}
