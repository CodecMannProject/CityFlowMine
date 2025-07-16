using System;
using System.Collections.Generic;
using System.Linq;
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

        public DriverStatus Status { get; set; }
        public List<string> LicenenceNumber { get; private set; } // Fixed the ambiguity by ensuring only one declaration exists
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
                AssignedBus = null;
            }
            else
            {
                throw new InvalidOperationException("Driver is not assigned to any bus.");
            }
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
    }
}
