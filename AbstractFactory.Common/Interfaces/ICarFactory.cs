namespace AbstractFactory.Common.Interfaces
{
    public interface ICarFactory
    {
        ICoupe CreateCoupe();
        ILimousine CreateLimousine();
        ISuW CreateSuW();
    }
}