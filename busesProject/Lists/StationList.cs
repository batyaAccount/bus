using busesProject.pages;

namespace busesProject.Lists
{
    public class StationList
    {
        public static List<Station> stations { get; set; } = new List<Station>();
        public List<Station> Get() { return stations; }
        public Station getById(int id)
        {
            return stations.Find(z => z.Id == id);

        }
        public bool post(Station station)
        {
            if (getById(station.Id) != null)
            {
                return false;
            }
            stations.Add(station);
            if (getById(station.Id).Equals(station))
            { return true; }
            return false;


        }
        public bool put(int id, Station station)
        {
            Station r = stations.Find(b => b.Id == id);
            if (r == null)
                return false;
            r.Id = station.Id;
            r.Name = station.Name;
            r.City = station.City;
            r.Street = station.Street;
            r.StationNumber = station.StationNumber;
            r.GpsWaypoint = station.GpsWaypoint;
            r.Type = station.Type;

            return true;

        }
        public bool delete(int id)
        {
            if (getById(id) != null)
                return stations.Remove(getById(id));
            return false;

        }
        public bool delete(string gps)
        {
            Station s = stations.Find(z => z.GpsWaypoint == gps);
            if(s == null)
                return false;
            return stations.Remove(s);

        }
    }
}
