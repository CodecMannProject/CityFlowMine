using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Incident
    {
        public Incident(Guid id, IncidentType incidentType, DateTime timeOfIncident, TransportVehicle vehicle, int latitude, int longitude)
        {
            Id = id;
            IncidentType = incidentType;
            TimeOfIncident = timeOfIncident;
            Vehicle = vehicle;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public Incident(Guid id, IncidentType incidentType, DateTime timeOfIncident, TransportVehicle vehicle, Route route, int latitude, int longitude)
        {
            Id = id;
            IncidentType = incidentType;
            TimeOfIncident = timeOfIncident;
            Vehicle = vehicle;
            Route = route;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public Guid Id { get; set; }
        public IncidentType IncidentType { get; set; }
        public DateTime TimeOfIncident { get; set; }
        public TransportVehicle Vehicle { get; set; }

        public Route? Route { get; set; }

        public int latitude { get; set; }
        public int longitude { get; set; }
    }
}
