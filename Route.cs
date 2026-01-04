namespace BusCompanyManagement
{
    internal class Route
    {
        public int RouteId { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }

        public Route(int routeId, string startLocation, string endLocation)
        {
            RouteId = routeId;
            StartLocation = startLocation;
            EndLocation = endLocation;
        }

        public override string ToString()
        {
            return $"Route ID: {RouteId}, {StartLocation} -> {EndLocation}";
        }
    }
}