using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    public class Bus : TransportVehicle
    {
        internal VehicleStatus status;
        [System.Text.Json.Serialization.JsonIgnore]
        public float CurrentVisualX { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public float CurrentVisualY { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public int NextStopIndex { get; set; }

        public Bus(string id, string model, string type, int capacity, int seats, VehicleStatus status) : base(id, model, type, capacity, seats, status)
        {
            FuelType = "Diesel";
            AreDorrsOpen = false;
            MaintanceHistory = new List<MaintanceRecord>();
            status = VehicleStatus.Available;
        }

        public string FuelType { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Fuel Type: {FuelType}";
        }

        public override void PrepareForDay()
        {
            throw new NotImplementedException();
        }

        public override void PerformMaintenance()
        {
            throw new NotImplementedException();
        }

        public override bool PerformPreTripCheck()
        {
            throw new NotImplementedException();
        }

    }
}
