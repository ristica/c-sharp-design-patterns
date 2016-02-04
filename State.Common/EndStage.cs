using System;

namespace State.Common
{
    public class EndStage : IState
    {
        public void GoToNextState(StateContext context)
        {
            Console.WriteLine("DONE!");
        }
    }
}
