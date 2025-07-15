using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    public class TransportSystem
    {
        public TransportSystem(List<Driver> drivers, List<Bus> buss, List<Route> routes, List<Stop> stops, List<Operator> operators)
        {
            Drivers = drivers;
            Buss = buss;
            Routes = routes;
            Stops = stops;
            this.operators = operators;
        }

        public List<Driver> Drivers { get; private set; }
        public List<Bus> Buss { get; private set; }
        public List<Route> Routes { get; private set; }
        public List<Stop> Stops { get; private set; }
        public List<Operator> operators { get; private set; }

        #region Керування водіями

        public void HireDriver(Driver driver)
        {
            if (driver != null && !Drivers.Contains(driver))
            {
                Drivers.Add(driver);
                Console.WriteLine($"Driver {driver.FullName} added to the system.");
            }
            else
            {
                Console.WriteLine("Driver already exists or is null.");
            }
        }
        public void FireDriver(Driver driver)
        {
            if (driver != null && Drivers.Contains(driver))
            {
                Drivers.Remove(driver);
                Console.WriteLine($"Driver {driver.FullName} removed from the system.");
            }
            else
            {
                Console.WriteLine("Driver not found or is null.");
            }
        }
        #endregion

        #region Керування автобусами   
        public void RegisterNewBus(Bus bus)
        {
            if (bus != null && !Buss.Contains(bus))
            {
                Buss.Add(bus);
                Console.WriteLine($"Bus {bus.ToString()} added to the system.");
            }
            else
            {
                Console.WriteLine("Bus already exists or is null.");
            }
        }
        public void SendBusToRepair(Bus bus)
        {
            if (bus != null && Buss.Contains(bus))
            {
                bus.SendToRepair();
                Console.WriteLine($"Bus {bus.ToString()} sent for maintenance.");
            }
            else
            {
                Console.WriteLine("Bus not found or is null.");
            }
        }
        public void ReturnBusFromRepair(Bus bus)
        {
            if (bus != null && Buss.Contains(bus))
            {
                bus.GoOnRoute();
                Console.WriteLine($"Bus {bus.ToString()} returned from maintenance.");
            }
            else
            {
                Console.WriteLine("Bus not found or is null.");
            }
        }
        #endregion
        #region Операційна діяльність
        public void AssignRouteToBus(Bus bus, Route route)
        {
            var driver = Drivers.FirstOrDefault(d => d.AssignedBus == bus);
            var bus = Buss.FirstOrDefault(b => b == bus);

            if (driver != null && bus != null && Routes.Contains(route))
            {
                route.vechicleType = bus.VechicleType;
                route.StartStop = Stops.FirstOrDefault(s => s.Name == route.StartStop.Name);
                route.EndStop = Stops.FirstOrDefault(s => s.Name == route.EndStop.Name);
                Console.WriteLine($"Route {route.Number} assigned to bus {bus.ToString()} with driver {driver.FullName}.");
            }
            else
            {
                Console.WriteLine("Driver, bus, or route not found or is null.");
            }
        }
        public void CompleteShift(Operator operatorObj)
        {
            if (operators.Contains(operatorObj))
            {
                Console.WriteLine($"Operator {operatorObj.Name} has completed their shift.");
                foreach (var bus in operatorObj.Buses)
                {
                    bus.Status = VechicleStatus.InDepot;
                    Console.WriteLine($"Bus {bus.ToString()} is now in depot.");
                }
            }
            else
            {
                Console.WriteLine("Operator not found or is null.");
            }
        }
        #endregion
    }
}