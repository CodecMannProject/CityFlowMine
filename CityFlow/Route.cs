namespace CityFlow
{
<<<<<<< HEAD
    internal class Route
    {
        public Route(string number, string start, string end)
        {
            Number = number;
            Start = start;
            End = end;
        }

        public string Number { get; }
        public string Start { get; }
        public string End { get; }
        public List<Route> _allRoutes = new List<Route>();
    }
=======
    public class Route
    {
        private string start;
        private string end;

        public Route(string number, string start, string end)
        {
            Number = number;
            this.start = start;
            this.end = end;
        }

        public Route(string number, VechicleType vechicleType, Stop startStop, Stop endStop, List<Stop> stops)
        {
            Number = number;
            this.vechicleType = vechicleType;
            StartStop = startStop;
            EndStop = endStop;
            Stops = stops;
        }

        public string Number { get; private set; }
        public VechicleType vechicleType { get; set; }
        public Stop StartStop { get; private set; }
        public Stop EndStop { get; private set; }
        public List<Stop> Stops { get; private set; }

        public void AddIntermadiateStop(Stop stop)
        {
            if (Stops == null)
            {
                Stops = new List<Stop>();
            }
            Stops.Add(stop);
        }
        public void InsertIntermadiateStop(int index, Stop stop)
        {
            if (Stops == null)
            {
                Stops = new List<Stop>();
            }
            if (index < 0 || index > Stops.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            Stops.Insert(index, stop);
        }
        public bool RemoveIntermadiateStop(Stop stop)
        {
            if (Stops != null && Stops.Contains(stop))
            {
                return Stops.Remove(stop);
            }
            else 
            { 
                return false; 
            }
        }
    }  
>>>>>>> Add project files.
}