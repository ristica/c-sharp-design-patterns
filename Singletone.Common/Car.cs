namespace Singletone.Common
{
    public class Car
    {
        private static readonly Car Instance = new Car();

        private Car() {}

        public static Car GetInstance()
        {
            return Instance;
        }
    }
}
