using System;
using System.Collections.Generic;
using System.Text;

namespace _04.State.States
{
    public class InitialState : AState
    {
        public override void DoWork()
        {
            Console.WriteLine("DoWork in : Initial State");
            Save();
        }

        public override void Save()
        {
            Console.WriteLine("Save in: Initial State");
            Context.UpdateState(new IntermediateState());
        }
    }
}
