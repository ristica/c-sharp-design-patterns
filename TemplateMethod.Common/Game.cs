namespace TemplateMethod.Common
{
    public abstract class Game
    {
        protected abstract void InitializeGame();
        protected abstract void StartGame();
        protected abstract void EndGame();

        public void Play()
        {
            this.InitializeGame();
            this.StartGame();
            this.EndGame();
        }
    }
}
