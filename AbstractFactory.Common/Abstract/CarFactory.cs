namespace AbstractFactory.Common.Abstract
{
    public abstract class CarFactory
    {
        public abstract Coupe CreateCoupe();
        public abstract Limousine CreateLimousine();
        public abstract SuW CreateSuW();
    }
}
