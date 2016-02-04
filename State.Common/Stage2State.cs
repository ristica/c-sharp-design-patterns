using System;

namespace State.Common
{
    public class Stage2State : IState
    {
        public void GoToNextState(StateContext context)
        {
            context.State = new Stage3State();
            Console.WriteLine("You're on the second stage...");
        }
    }
}
