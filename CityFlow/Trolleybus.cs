using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Trolleybus : TransportVehicle
    {
        public int BatteryLifeHours { get; set; }
        public Trolleybus(int id, string model, string type, int capacity, int batteryLifeHours) : base(id, model, type, capacity)
        {
            BatteryLifeHours = batteryLifeHours;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Battery Life: {BatteryLifeHours} hours";
        }
}
