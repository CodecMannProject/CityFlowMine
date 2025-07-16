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
        public List<Stop> Stations { get; set; }
        public RouteShedule(int routeId, string routeName)
        {
            RouteId = routeId;
            RouteName = routeName;
            Stations = new List<Stop>();
        }
        public void AddStation(Stop station)
        {
            Stations.Add(station);
            Console.WriteLine($"Added station {station.Name} to route {RouteName}.");
        }
        public void RemoveStation(Stop station)
        {
            if (Stations.Remove(station))
            {
                Console.WriteLine($"Removed station {station.Name} from route {RouteName}.");
            }
            else
            {
                Console.WriteLine($"Station {station.Name} not found in route {RouteName}.");
            }
        }
    }
}
