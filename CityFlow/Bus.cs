using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Bus : TransportVehicle,IPassengerCarrier
    {
        public Bus(int id, string model, string type, int capacity,bool status) : base(id, model, type, capacity,status)
        {
            FuelType = "Diesel";
            AreDorrsOpen = false;
        }

        public string FuelType { get; set; }
        public bool AreDorrsOpen { get; set; }
        public int CurrentPassengerCount => throw new NotImplementedException();

       

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
    }
}
