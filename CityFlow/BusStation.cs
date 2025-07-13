using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class BusStation
    {
        public BusStation(int stationId, string stationName, int peopleWaiting)
        {
            StationId = stationId;
            StationName = stationName;
            PeopleWaiting = peopleWaiting;
        }

        public int StationId { get; set; }
        public string StationName { get; set; }
        public int PeopleWaiting { get; set; }

        public void PassengerBoarding(int count)
        {
            if (PeopleWaiting >= count)
            {
                PeopleWaiting -= count;
                Console.WriteLine($"{count} people boarded the bus at {StationName}. People waiting now: {PeopleWaiting}");
            }
            else
            {
                Console.WriteLine($"Not enough people waiting at {StationName} to board {count} passengers.");
            }
        }
        public void PassengerArriving(int count)
        {
            PeopleWaiting += count;
            Console.WriteLine($"{count} people arrived at {StationName}. People waiting now: {PeopleWaiting}");
        }
    }
}
