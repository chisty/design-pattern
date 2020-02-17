using System;
using System.Collections.Generic;
using System.Text;

namespace _04.State
{
    public class Context
    {
        private IState State { get; set; }

        public Context(IState state)
        {
            UpdateState(state);
        }

        public void UpdateState(IState state)
        {
            State = state;
            state.SetContext(this);
        }

        public void DoWork()
        {
            State.DoWork();
        }

        public void Save()
        {
            State.Save();
        }
    }
}
