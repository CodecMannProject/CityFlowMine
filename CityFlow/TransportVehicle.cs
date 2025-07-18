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
        protected VechicleStatus _status;

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

        protected TransportVehicle(int id, string model, string type, int capacity, VechicleStatus status)
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

        protected TransportVehicle(string id, string model, string type, int capacity, int seats, VechicleStatus status)
        {
            _model = model;
            _type = type;
            Capacity = capacity;
            _status = status;
            _totalSeats = seats;
        }

        public virtual string GetInfo()
        {
            return $"ID: {_id}, Model: {_model}, Type: {_type}, Capacity: {_capacity} tons";
        }
        public abstract void PrepareForDay();

        public void AsiignRoute()
        {
            if(_status == VechicleStatus.InDepot)
            {
                _status = VechicleStatus.Available;
                if (PerformPreTripCheck())
                {
                    _status= VechicleStatus.OnRoute;

                }
                else
                {
                    _status = VechicleStatus.UnderMaintenance;
                    throw new InvalidOperationException("Pre-trip check failed. Vehicle is under maintenance.");
                }
            }
            else
            {
                throw new InvalidOperationException("Vehicle is not available for assignment.");
            }
        }

        public virtual void StartRoute()
        {
        }

        public virtual void EndRoute()
        {
        }
        public virtual void StopRoute() { }

        public virtual void ToDepot()
        {
        }
        public abstract void PerformMaintenance();
        public abstract bool PerformPreTripCheck();
    }

    public enum VechicleStatus
    {
        Available,
        InDepot,
        OnRoute,
        InService,
        UnderMaintenance,
        OutOfService
    }
}