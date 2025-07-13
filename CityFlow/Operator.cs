using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Operator
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Bus> Buses { get; set; }
        public List<RouteShedule> Routes { get; set; }
        public Operator(int id, string name)
        {
            Id = id;
            Name = name;
            Buses = new List<Bus>();
            Routes = new List<RouteShedule>();
        }
        public void AddBus(Bus bus)
        {
            Buses.Add(bus);
            Console.WriteLine($"Bus {(TransportVehicle)bus} added to operator {Name}.");
        }
        public void RemoveBus(Bus bus)
        {
            if (Buses.Remove(bus))
            {
                Console.WriteLine($"Bus {(TransportVehicle)bus} removed from operator {Name}.");
            }
            else
            {
                Console.WriteLine($"Bus {(TransportVehicle)bus} not found in operator {Name}.");
            }
        }
        public void AddRoute(RouteShedule route)
        {
            Routes.Add(route);
            Console.WriteLine($"Route {route.RouteName} added to operator {Name}.");
        }
        public void RemoveRoute(RouteShedule route)
        {
            if (Routes.Remove(route))
            {
                Console.WriteLine($"Route {route.RouteName} removed from operator {Name}.");
            }
            else
            {
                Console.WriteLine($"Route {route.RouteName} not found in operator {Name}.");
            }
        }

        public void StartShift()
        {
            Console.WriteLine($"Operator {Name} is starting the shift with {Buses.Count} buses and {Routes.Count} routes.");
            foreach (var bus in Buses)
            {
                bus.PrepareForDay();
                Console.WriteLine($"Bus {bus.GetInfo()} is ready for the day.");
            }
        }

        public void DriveToNextStopAndServicePassengers(Bus bus, BusStation station)
        {
            if(bus.status != VechicleStatus.OnRoute)
            {
                MessageBox.Show("Bus is not on route. Please assign a route first.");
            }
            else
            {
                int _currenindex = _currentStopIndex++;
                if (_currentindex < station.Stations.Count)
                {
                    var currentStation = station.Stations[_currentindex];
                    Console.WriteLine($"Bus {bus.GetInfo()} is driving to {currentStation.StationName}.");
                    bus.DisembarkPassengers(station.PeopleWaiting);
                    currentStation.PassengerBoarding(bus.CurrentPassengerCount);
                    bus.BoardPassengers(station.PeopleWaiting);
                }
                else
                {
                    Console.WriteLine("No more stations in the route.");
                }
            }
    }
}
