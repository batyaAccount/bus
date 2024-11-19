using busesProject.pages;

namespace busesProject.Lists
{
    public class StationList
    {
        public List<Station> GetStation() { return DataContextManager.DataContext.Stations; }
        public Station getByIdStation(int id)
        {
            return DataContextManager.DataContext.Stations.Find(z => z.Id == id);

        }
        public bool Add(Station station)
        {
          
            DataContextManager.DataContext.Stations.Add(station);
            if (getByIdStation(station.Id).Equals(station))
            { return true; }
            return false;


        }
        public bool Update(int id, Station station)
        {
            Station r = DataContextManager.DataContext.Stations.Find(b => b.Id == id);
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
        public bool DeleteStation(int id)
        {
            if (getByIdStation(id) != null)
                return DataContextManager.DataContext.Stations.Remove(getByIdStation(id));
            return false;

        }
        public bool DeleteStation(string gps)
        {
            Station s = DataContextManager.DataContext.Stations.Find(z => z.GpsWaypoint == gps);
            if(s == null)
                return false;
            return DataContextManager.DataContext.Stations.Remove(s);

        }
    }
}
