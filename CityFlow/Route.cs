
namespace CityFlow
{
    public class Route
    {
        private string start;
        private string end;

        public Route(string number, Stop startStop, Stop endStop, List<Stop> stops)
        {
            if (startStop == null)
                throw new ArgumentNullException(nameof(startStop), "Start stop cannot be null.");
            if (endStop == null)
                throw new ArgumentNullException(nameof(endStop), "End stop cannot be null.");

            Number = number;
            StartStop = startStop;
            EndStop = endStop;

            if (IntermediateStops != null)
            {
                IntermediateStops = new List<Stop>(IntermediateStops);
            }
        }

        public string Number { get; private set; }
        public VechicleType vechicleType { get; set; }
        public Stop StartStop { get;  set; }
        public Stop EndStop { get;  set; }
        public List<Stop> Stops { get; private set; }
        public IEnumerable<Stop> IntermediateStops { get; private set; } = new List<Stop>();

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
        public List<Stop> GetFullPath()
        {
            var fullPath = new List<Stop> { StartStop };
            fullPath.AddRange(IntermediateStops);
            fullPath.Add(EndStop);
            return fullPath;
        }
    }  
}