using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Tram : TransportVehicle, IPassengerCarrier
    {
        public int RailCarCount { get; set; }

        public int CurrentPassengerCount => throw new NotImplementedException();

        public Tram(int id, string model, string type, int capacity, int railCarCount) : base(id, model, type, capacity)
        {
            RailCarCount = railCarCount;
        }

        public Tram(int id, string model, string type, int capacity, VehicleStatus status) : base(id, model, type, capacity, status)
        {
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Rail Cars: {RailCarCount}";
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
