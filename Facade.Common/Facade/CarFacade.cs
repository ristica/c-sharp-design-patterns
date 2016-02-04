using Facade.Common.Packages;

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
            this._type.SetCarType();
            this._model.SetCarModel();
            this._cubicCapacity.SetCubicCapacity();
            this._transmition.SetCarTransmition();
        }
    }
}
