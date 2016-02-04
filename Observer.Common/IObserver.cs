namespace Observer.Common
{
    public interface IObserver
    {
        string Name { get; set; }
        void Update(string message);
    }
}
