using busesProject.pages;

namespace busesProject.Lists
{
    public class RouteList
    {
        public static List<route> routes { get; set; } = new List<route>();
        public List<route> Get() { return routes; }
        public route getById(int id)
        {
            return routes.Find(z => z.Id == id);

        }
        public bool post(route route)
        {
            if (getById(route.Id) != null)
            {
                return false;
            }
            routes.Add(route);
            if (getById(route.Id).Equals(route))
            { return true; }
            return false;


        }
        public bool put(int id, route route)
        {
            route r = routes.Find(b => b.Id == id);
            if (r == null)
                return false;
           r.Id=route.Id;
           r.BusLineId = route.BusLineId;
           r.Driver = route.Driver;
           r.Station = route.Station;
           r.SourceStationId = route.SourceStationId;
           r.HourOfFirstBus = route.HourOfFirstBus;
           r.HourOfLastBus = route.HourOfLastBus;

            return true;

        }
        public bool delete(int id)
        {
            if (getById(id) != null)
                return routes.Remove(getById(id));
            return false;
          

        }
        public List<route> GetByStation(int station)
        {
            return routes.FindAll(b => b.Station==station);
        }
        public List<route> GetByBusLine(int busLine)
        {
            return routes.FindAll(b => b.BusLineId==busLine);
        }
    }
}
