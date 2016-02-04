namespace State.Common
{
    public class StateContext
    {
        public IState State { get; set; }

        public StateContext(IState state)
        {
            this.State = state;
        }

        public void RequestStateChange()
        {
            this.State.GoToNextState(this);
        }
    }
}
