namespace CityFlow
{
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
}