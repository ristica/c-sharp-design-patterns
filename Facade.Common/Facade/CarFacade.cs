using Facade.Common.CarParts;

namespace Facade.Common.Facade
{
    public class CarFacade
    {
        private readonly CarType _type;
        private readonly CarModel _model;
        private readonly CarCubicCapacitiy _cubicCapacity;
        private readonly CarTransmition _transmition;

        public CarFacade()
        {
            this._type = new CarType();
            this._model = new CarModel();
            this._cubicCapacity = new CarCubicCapacitiy();
            this._transmition = new CarTransmition();
        }

        public void CreateAudi()
        {
            this._type.SetCarType("A8");
            this._model.SetCarModel("4D2 Quattro");
            this._cubicCapacity.SetCubicCapacity("4.200 cm³");
            this._transmition.SetCarTransmition("automatic");
        }
    }
}
