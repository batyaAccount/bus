namespace busesProject.pages
{
    public enum typeOfStstion { urban, interstate }
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int StationNumber { get; set; }
        public string GpsWaypoint { get; set; }
        public typeOfStstion Type { get; set; }

        public Station(int id, string name, string city, string street, int stationNumber, string gpsWaypoint, typeOfStstion type)
        {
            Id = id;
            Name = name;
            City = city;
            Street = street;
            StationNumber = stationNumber;
            GpsWaypoint = gpsWaypoint;
            this.Type = type;
        }

        public Station()
        {
        }
    }
}
