using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    public abstract class TransportVehicle
    {
        protected int _id;
        protected string _model;
        private string _type;
        private int _maxSittingPassengers;
        private int _maxStandingPassengers;
        protected int _totalSeats;
        private int _capacity;
        private int _year;
        protected VehicleStatus _status;

        public int TotalMaxPassengers
        {
            get
            {
                if (_maxSittingPassengers == null && _maxStandingPassengers == null)
                {
                    return _totalSeats;
                } else
                {
                    return _maxSittingPassengers + _maxStandingPassengers;
                }
            }
            private set { _totalSeats = value; }
        }

        public int Capacity
        {
            get 
            { 
                return _capacity; 
            }
            set
            {
                if (value >= 0)
                {
                    _capacity = value;
                }
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value <= DateTime.Now.Year + 1)
                {
                    _year = value;
                }
            }
        }

        protected TransportVehicle(int id, string model, string type, int capacity, VehicleStatus status)
        {
            _id = id;
            _model = model;
            _type = type;
            Capacity = capacity;
            _status = status;
        }

        protected TransportVehicle(int id, string model, string type, int capacity)
        {
            _id = id;
            _model = model;
            _type = type;
            Capacity = capacity;
        }

        protected TransportVehicle(string id, string model, string type, int capacity, int seats, VehicleStatus status)
        {
            _model = model;
            _type = type;
            Capacity = capacity;
            _status = status;
            _totalSeats = seats;
        }
        public Driver? AssignedDriver { get; set; }
        public bool AreDorrsOpen { get; set; }
        public bool AreLightsOn { get; set; }
        public List<MaintanceRecord> MaintanceHistory { get; set; }
        public int Millage { get; private set; }
        public Route AssignedRoute { get; internal set; }

        public string Model
        {
            get
            {
                if (_totalSeats % 10 == 0 || Enumerable.Range(5, 9).Contains(_totalSeats % 10) || Enumerable.Range(11, 19).Contains(_totalSeats))
                {
                    return $"{_model} ({_totalSeats} місць)";
                }
                else if (_totalSeats % 10 == 1)
                {
                    return $"{_model} ({_totalSeats} місце)";
                }
                else if (Enumerable.Range(2, 4).Contains(_totalSeats % 10))
                {
                    return $"{_model} ({_totalSeats} місця)";
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

            }
        }

        public virtual string GetInfo()
        {
            return $"ID: {_id}, Model: {_model}, Type: {_type}, Capacity: {_capacity} tons";
        }
        public abstract void PrepareForDay();

        public abstract bool PerformPreTripCheck();

        public abstract void PerformMaintenance();

        public void AsiignRoute()
        {
            if(_status == VehicleStatus.InDepot)
            {
                _status = VehicleStatus.Available;
                if (PerformPreTripCheck())
                {
                    _status= VehicleStatus.OnRoute;

                }
                else
                {
                    _status = VehicleStatus.UnderMaintenance;
                    throw new InvalidOperationException("Pre-trip check failed. Vehicle is under maintenance.");
                }
            }
            else
            {
                throw new InvalidOperationException("Vehicle is not available for assignment.");
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
        public VehicleStatus GetStatus()
        {
            return _status;
        }

        public void SendToRepair()
        {
            if (_status == VehicleStatus.UnderMaintenance)
            {
                _status = VehicleStatus.InDepot;
                Console.WriteLine("Bus is now in repair.");
            }
            else
            {
                throw new InvalidOperationException("Bus is not under maintenance.");
            }
        }
        public void ReturnFromRepair()
        {
            if (_status == VehicleStatus.InDepot)
            {
                _status = VehicleStatus.Available;
                Console.WriteLine("Bus has returned from repair and is now available.");
            }
            else
            {
                throw new InvalidOperationException("Bus is not in depot.");
            }
        }

        public void InIncident()
        {
            _status = VehicleStatus.InIncident;
            Console.WriteLine("Bus is now on route.");
        }

        public void SendAfterIncident(VehicleStatus selectedStatus)
        {
            if (_status == VehicleStatus.InIncident && selectedStatus == null)
            {
                _status = selectedStatus;
                Console.WriteLine($"Bus has returned from incident and is now {_status.ToString().ToLower()}.");
            }
            else if (selectedStatus != null)
            {
                throw new InvalidOperationException("Bus isn't in an incident.");
            } else
            {
                throw new ArgumentNullException("Selected status is null.");
            }
        }

        public void GoOnRoute()
        {
            if (_status == VehicleStatus.Available)
            {
                _status = VehicleStatus.OnRoute;
                Console.WriteLine("Bus is now on route.");
            }
            else
            {
                throw new InvalidOperationException("Bus is not available for route assignment.");
            }
        }
        public void GoToDepot()
        {
            if (_status == VehicleStatus.OnRoute)
            {
                _status = VehicleStatus.InDepot;
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