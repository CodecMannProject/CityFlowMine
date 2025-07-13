using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class RouteShedule
    {
        public int RouteId { get; set; }
        public string RouteName { get; set; }
        public List<BusStation> Stations { get; set; }
        public RouteShedule(int routeId, string routeName)
        {
            RouteId = routeId;
            RouteName = routeName;
            Stations = new List<BusStation>();
        }
        public void AddStation(BusStation station)
        {
            Stations.Add(station);
            Console.WriteLine($"Added station {station.StationName} to route {RouteName}.");
        }
        public void RemoveStation(BusStation station)
        {
            if (Stations.Remove(station))
            {
                Console.WriteLine($"Removed station {station.StationName} from route {RouteName}.");
            }
            else
            {
                Console.WriteLine($"Station {station.StationName} not found in route {RouteName}.");
            }
        }
    }
}
