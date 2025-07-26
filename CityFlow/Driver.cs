using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    public class Driver
    {
        public Guid EmployeeId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime _dateOfBirth;
        private string employeeId;
        private string _model;

        public Driver(Guid employeeId, string firstName, string lastName, DateTime dateOfBirth, DriverStatus status)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            _dateOfBirth = dateOfBirth;
            Status = status;
            LicenenceNumber = new List<string>();
            WorkHistory = new List<string>();
            WorkHistory.Add($"Driver {FullName} hired on {DateTime.Now.ToShortDateString()}");
        }

        public Driver(Guid employeeId, string firstName, string lastName, DateTime dateOfBirth)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            _dateOfBirth = dateOfBirth;
        }

        protected DriverStatus Status { get; set; }
        public List<string> LicenenceNumber { get; private set; } 
        public Bus? AssignedBus { get; set; }
        public List<string> WorkHistory { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - _dateOfBirth.Year;
                if (_dateOfBirth > today.AddYears(-age)) age--;
                return age;
            }
        }
        public void AssignVehicle(Bus bus)
        {
            if (AssignedBus == null)
            {
                AssignedBus = bus;
                bus.AssignedDriver = this;
                WorkHistory.Add($"Assigned to bus {bus.ToString()} on {DateTime.Now.ToShortDateString()}");
            }
            else
            {
                throw new InvalidOperationException("Driver is already assigned to a bus.");
            }
        }
        public void ReleaseFromVehicle()
        {
            if (AssignedBus != null)
            {
                WorkHistory.Add($"Released from bus {AssignedBus.ToString()} on {DateTime.Now.ToShortDateString()}");
                AssignedBus.AssignedDriver = null;
                AssignedBus = null;
            }
            else
            {
                throw new InvalidOperationException("Driver is not assigned to any bus.");
            }
        }

        public void InIncident()
        {
            Status = DriverStatus.InIncident;
        }

        public void GoOnSeakLeave()
        {
            if (Status != DriverStatus.SickLeave)
            {
                Status = DriverStatus.SickLeave;
                WorkHistory.Add($"Driver {FullName} went on leave on {DateTime.Now.ToShortDateString()}");
            }
            else
            {
                throw new InvalidOperationException("Driver is already on leave.");
            }
        }
        public void ReturnFromSickLeave()
        {
            if (Status == DriverStatus.SickLeave)
            {
                Status = DriverStatus.Available;
                WorkHistory.Add($"Driver {FullName} returned from leave on {DateTime.Now.ToShortDateString()}");
            }
            else
            {
                throw new InvalidOperationException("Driver is not on leave.");
            }
        }

        public void OpenDoors()
        {
            if (AssignedBus == null)
            {
                throw new NullReferenceException();
            }
            else 
            {
                if (!AssignedBus.AreDorrsOpen)
                {
                    AssignedBus.AreDorrsOpen = true;
                    Console.WriteLine("Doors are now open.");
                }
                else
                {
                    Console.WriteLine("Doors are already open.");
                }
            }
        }

        public void CloseDoors()
        {
            if (AssignedBus == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (AssignedBus.AreDorrsOpen)
                {
                    AssignedBus.AreDorrsOpen = false;
                    Console.WriteLine("Doors are now closed.");
                }
                else
                {
                    Console.WriteLine("Doors are already closed.");
                }
            }
        }

        public void TurnLightsOn()
        {
            if (AssignedBus == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (!AssignedBus.AreLightsOn)
                {
                    AssignedBus.AreLightsOn = true;
                    Console.WriteLine("Lights are now on");
                }
                else
                {
                    Console.WriteLine("Lights are already on");
                }
            }
        }

        public void TurnLightsOff()
        {
            if (AssignedBus == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (AssignedBus.AreLightsOn)
                {
                    AssignedBus.AreLightsOn = false;
                    Console.WriteLine("Lights are now off");
                }
                else
                {
                    Console.WriteLine("Lights are already off");
                }
            }
        }
    }
}
