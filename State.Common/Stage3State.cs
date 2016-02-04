using System;

namespace State.Common
{
    public class Stage3State : IState
    {
        public void GoToNextState(StateContext context)
        {
            context.State = new EndStage();
            Console.WriteLine("You're almost there: Stage 3!");
        }
    }
}
