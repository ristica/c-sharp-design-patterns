using System;
using Proxy.Common.Object;
using Proxy.Common.RealObject;
using Proxy.Common.Subject;

namespace Proxy.Common.Proxy
{
    public class CarProxy : ICar
    {
        private readonly Driver _driver;
        private readonly ICar _car;

        public CarProxy(Driver driver)
        {
            this._driver = driver;
            this._car = new Car();
        }

        public void Drive()
        {
            if (this._driver.Age < 18)
            {
                Console.Write("the driver is too young to drive the car!");
            }
            else
            {
                this._car.Drive();
            }
        }
    }
}
