using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    public class Stop
    {
        public Stop(Guid id, string name, string direction, string location, StopType type, double latitude, double longitude)
        {
            Id = id;
            Name = name;
            Direction = direction;
            Location = location;
            Type = type;
            Latitude = latitude;
            Longitude = longitude;
        }

        public Guid Id { get;private set; }
        public string Name { get; set; }
        public string Direction { get; set; }
        public string Location { get; set; }
        public StopType Type { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
