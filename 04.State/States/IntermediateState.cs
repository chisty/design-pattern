using System;

namespace _04.State.States
{
    public class IntermediateState : AState
    {
        public override void DoWork()
        {
            Console.WriteLine("DoWork in : Intermediate State");
            Save();
        }

        public override void Save()
        {
            Console.WriteLine("Save in: Intermediate State");
            Context.UpdateState(new FinalState());
        }
    }
}