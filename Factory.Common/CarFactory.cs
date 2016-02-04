namespace Factory.Common
{
    public static class CarFactory
    {
        public static ICar GetCar(CarType carType)
        {
            switch (carType)
            {
                case CarType.Coupe:
                    return new Coupe();
                case CarType.Limousine:
                    return new Limousine();
                case CarType.SuV:
                    return new SuV();
                default:
                    return null;
            }
        }
    }
}
