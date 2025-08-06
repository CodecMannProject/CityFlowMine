using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CityFlow
{
    internal class Operator : Employee
    {
        public Operator(string EmployeeId, string login, string passwordHash, string firstName, string lastName, EmployeeStatus status) : base(EmployeeId, login, passwordHash, firstName, lastName, status)
        {
        }
        public override string GetRoleDescription() => "Operator: Monitors and manages the bus fleet, ensuring efficient operations and safety compliance.";

        public Incident RegisterIncident(IncidentType incidentType, List<TransportVehicle> involvedVehicles, Route route, int latitude, int longitude, DateTime providedDateTime)
        {
            if (providedDateTime == null)
            {
                Console.WriteLine("Date & Time not provided. Using current instead.");
                providedDateTime = DateTime.Now;
            }

            if (latitude != null && longitude != null && route != null)
            {
                Incident registeredIncident = new Incident(Guid.NewGuid(), incidentType, providedDateTime, involvedVehicles, route, latitude, longitude);
                return registeredIncident;
            } else if (latitude != null && longitude != null)
            {
                Console.WriteLine("No route provided, assuming incident happened not on a Route.");
                Incident registeredIncident = new Incident(Guid.NewGuid(), incidentType, providedDateTime, involvedVehicles, latitude, longitude);
                return registeredIncident;
            } else
            {
                throw new ArgumentNullException("Latitude / Longitude not provided, unable to register incident.");
            }

        }

        public void MoveVehicleAfterIncident(TransportVehicle Vehicle, VehicleStatus location)
        {
            Vehicle.SendAfterIncident(location);
        }

        public void ControlNonRegisteredIncident(List<TransportVehicle> involvedVehicles, IncidentType incidentType, Route route, int latitude, int longitude, DateTime providedDateTime)
        {
            Incident registeredIncident = RegisterIncident(incidentType, involvedVehicles, route, latitude, longitude, providedDateTime);
            ControlRegisteredIncident(registeredIncident);
        }

        public void ControlRegisteredIncident(Incident incident)
        {
            ReportIncidentToPolice(incident);
            CallAmbulance(incident);
            
            for (int i = 0; i < incident.VehiclesInvolved.Count; i++)
            {
                incident.VehiclesInvolved[i].AssignedDriver?.InIncident();
                incident.VehiclesInvolved[i].InIncident();
            }
        }

        public void ReportIncidentToPolice(Incident incident) { }
        public void CallAmbulance(Incident incident) { }
    }
}
