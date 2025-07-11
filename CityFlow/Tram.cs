using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Tram : TransportVehicle
    {
        public int RailCarCount { get; set; }

        public Tram(int id, string model, string type, int capacity, int railCarCount) : base(id, model, type, capacity)
        {
            RailCarCount = railCarCount;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Rail Cars: {RailCarCount}";
        }
    }
}
