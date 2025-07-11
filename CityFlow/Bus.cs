using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Bus : TransportVehicle
    {
        public string FuelType { get; set; }

        public Bus(int id, string model, string type, int capacity, string fuelType) : base(id, model, type, capacity)
        {
            FuelType = fuelType;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Fuel Type: {FuelType}";
        }
}
