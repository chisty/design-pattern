using System;

namespace _04.State.States
{
    public class FinalState : AState
    {
        public override void DoWork()
        {
            Console.WriteLine("DoWork in : Final State");
            Save();
        }

        public override void Save()
        {
            Console.WriteLine("Save in: Final State");
            Console.WriteLine("Process Complete");
        }
    }
}