using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class TransportVehicle
    {
        private int _id;
        private string _model;
        private string _type;
        private int _capacity;
        private int _year;
        public int Capacity
        {
            get { return _capacity; }
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
                if (value <= DateTime.Now.Year+1)
                {
                    _year = value;
                }
            }
        }
        public TransportVehicle(int id, string model, string type, int capacity)
        {
            _id = id;
            _model = model;
            _type = type;
            _capacity = capacity;
        }
        public virtual string GetInfo()
        {
            return $"ID: {_id}, Model: {_model}, Type: {_type}, Capacity: {_capacity} tons";
        }
    }
}
