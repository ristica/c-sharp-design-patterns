using System;

namespace State.Common
{
    public class StartState : IState
    {
        public void GoToNextState(StateContext context)
        {
            context.State = new Stage2State();
            Console.WriteLine("Starting...");
        }
    }
}
