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
        private double _capacity;

        public TransportVehicle(int id, string model, string type, double capacity)
        {
            _id = id;
            _model = model;
            _type = type;
            _capacity = capacity;
        }
        public string GetInfo()
        {
            return $"ID: {_id}, Model: {_model}, Type: {_type}, Capacity: {_capacity} tons";
        }
    }
}
