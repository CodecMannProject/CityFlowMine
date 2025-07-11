using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Bus : TransportVehicle,IPassengerCarrier
    {
        public string FuelType { get; set; }

        public int CurrentPassengerCount => throw new NotImplementedException();

        public Bus(int id, string model, string type, int capacity, string fuelType) : base(id, model, type, capacity)
        {
            FuelType = fuelType;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Fuel Type: {FuelType}";
        }

        public override void PrepareForDay()
        {
            throw new NotImplementedException();
        }

        public void BoardPassengers(int count)
        {
            throw new NotImplementedException();
        }

        public void DisembarkPassengers(int count)
        {
            throw new NotImplementedException();
        }
    }
}
