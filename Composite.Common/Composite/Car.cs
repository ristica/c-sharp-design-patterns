using System;
using System.Collections.Generic;
using Composite.Common.Component;

namespace Composite.Common.Composite
{
    public class Car : IVehicle
    {
        private readonly List<IVehicle> _vehicles;
 
        public Car()
        {
            this._vehicles = new List<IVehicle>();
        }

        public void Add(IVehicle vehicle)
        {
            this._vehicles.Add(vehicle);
        }

        public void Remove(IVehicle vehicle)
        {
            this._vehicles.Remove(vehicle);
        }

        public void AddRange(params IVehicle[] vehicles)
        {
            this._vehicles.AddRange(vehicles);
        }

        public void Print()
        {
            foreach (var v in this._vehicles)
            {
                v.Print();
            }
        }
    }
}
