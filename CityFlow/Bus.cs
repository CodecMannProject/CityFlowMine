using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    public class Bus : TransportVehicle
    {
        internal VehicleStatus status;
        [System.Text.Json.Serialization.JsonIgnore]
        public float CurrentVisualX { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public float CurrentVisualY { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public int NextStopIndex { get; set; }

        public Bus(string id, string model, string type, int capacity, VechicleStatus status) : base((string)id, model, type, capacity, status)
        {
            FuelType = "Diesel";
            AreDorrsOpen = false;
            MaintanceHistory = new List<MaintanceRecord>();
            status = VechicleStatus.Available;

        }
        public string FuelType { get; set; }
        public bool AreDorrsOpen { get; set; }
        public List<MaintanceRecord> MaintanceHistory { get; set; }
        public int Millage { get; private set; }
        public Route AssignedRoute { get; internal set; }

        public string Model
        {
            get { return $"{Capacity}"; }
        }

        private void OpenDoors()
        {
            if (!AreDorrsOpen)
            {
                AreDorrsOpen = true;
                Console.WriteLine("Doors are now open.");
            }
            else
            {
                Console.WriteLine("Doors are already open.");
            }
        }

        private void CloseDoors()
        {
            if (AreDorrsOpen)
            {
                AreDorrsOpen = false;
                Console.WriteLine("Doors are now closed.");
            }
            else
            {
                Console.WriteLine("Doors are already closed.");
            }
        }

        public int BoardPassengers(int PassengerCount)
        {
            if (!AreDorrsOpen)
            {
                MessageBox.Show("Please open the doors before boarding passengers.");
                return 0;
            }
            else
            {
                int avaliableSeats = Capacity - PassengerCount;
                if (avaliableSeats <= 0)
                {
                    MessageBox.Show("No available seats to board passengers.");
                    return PassengerCount;
                }
                else
                {
                    int boardingCount = Math.Min(avaliableSeats, PassengerCount);
                    PassengerCount += boardingCount;
                    Console.WriteLine($"{boardingCount} passengers boarded the bus.");
                }
            }
            return PassengerCount;
        }

        public int DisembarkPassengers(int PassengerCount)
        {
            if (!AreDorrsOpen)
            {
                MessageBox.Show("Please open the doors before disembarking passengers.");
                return 0;
            }
            else
            {
                if (PassengerCount <= 0)
                {
                    MessageBox.Show("No passengers to disembark.");
                    return 0;
                }
                else
                {
                    Console.WriteLine($"{PassengerCount} passengers disembarked the bus.");
                    return PassengerCount;
                }
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Fuel Type: {FuelType}";
        }

        public override void PrepareForDay()
        {
            throw new NotImplementedException();
        }

        public override void PerformMaintenance()
        {
            throw new NotImplementedException();
        }

        public override bool PerformPreTripCheck()
        {
            throw new NotImplementedException();
        }
        public VechicleStatus GetStatus()
        {
            return _status;
        }

        public void SendToRepair()
        {
            if (_status == VechicleStatus.UnderMaintenance)
            {
                _status = VechicleStatus.InDepot;
                Console.WriteLine("Bus is now in repair.");
            }
            else
            {
                throw new InvalidOperationException("Bus is not under maintenance.");
            }
        }
        public void ReturnFromRepair()
        {
            if (_status == VechicleStatus.InDepot)
            {
                _status = VechicleStatus.Available;
                Console.WriteLine("Bus has returned from repair and is now available.");
            }
            else
            {
                throw new InvalidOperationException("Bus is not in depot.");
            }
        }
        public void GoOnRoute()
        {
            if (_status == VechicleStatus.Available)
            {
                _status = VechicleStatus.OnRoute;
                Console.WriteLine("Bus is now on route.");
            }
            else
            {
                throw new InvalidOperationException("Bus is not available for route assignment.");
            }
        }
        public void GoToDepot()
        {
            if (_status == VechicleStatus.OnRoute)
            {
                _status = VechicleStatus.InDepot;
                Console.WriteLine("Bus is now in depot.");
            }
            else
            {
                throw new InvalidOperationException("Bus is not on route.");
            }
        }
        public void AddMaintenanceRecord(MaintanceRecord record)
        {
            if (MaintanceHistory == null)
            {
                MaintanceHistory = new List<MaintanceRecord>();
            }
            MaintanceHistory.Add(record);
        }
        public void UpdateMillage(int newMillage)
        {
            if (newMillage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(newMillage), "Millage cannot be negative.");
            }
            Millage = newMillage;
            Console.WriteLine($"Millage updated to {Millage} km.");
        }
    }
}
