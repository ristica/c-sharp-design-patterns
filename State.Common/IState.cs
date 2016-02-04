namespace State.Common
{
    public interface IState
    {
        void GoToNextState(StateContext context);
    }
}
