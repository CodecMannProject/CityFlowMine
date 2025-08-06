using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Incident
    {
        public Incident(Guid id, IncidentType incidentType, DateTime timeOfIncident, List<TransportVehicle> vehiclesInvolved, int latitude, int longitude)
        {
            Id = id;
            IncidentType = incidentType;
            TimeOfIncident = timeOfIncident;
            VehiclesInvolved = vehiclesInvolved;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public Incident(Guid id, IncidentType incidentType, DateTime timeOfIncident, List<TransportVehicle> vehiclesInvolved, Route route, int latitude, int longitude)
        {
            Id = id;
            IncidentType = incidentType;
            TimeOfIncident = timeOfIncident;
            VehiclesInvolved = vehiclesInvolved;
            Route = route;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public Guid Id { get; set; }
        public IncidentType IncidentType { get; set; }
        public DateTime TimeOfIncident { get; set; }
        public List<TransportVehicle> VehiclesInvolved { get; set; }

        public Route? Route { get; set; }

        public int latitude { get; set; }
        public int longitude { get; set; }
    }
}
