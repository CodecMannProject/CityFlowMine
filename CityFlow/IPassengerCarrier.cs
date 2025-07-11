using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal interface IPassengerCarrier
    {
        void BoardPassengers(int count); 
        void DisembarkPassengers(int count);
        int CurrentPassengerCount { get; }
    }
}
