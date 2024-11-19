using busesProject.pages;

namespace busesProject.Lists
{
    public class RouteList
    {
        public List<route> GetRoute() { return DataContextManager.DataContext.Routes; }
        public route getByIdRoute(int id)
        {
            return DataContextManager.DataContext.Routes.Find(z => z.Id == id);

        }
        public bool Add(route route)
        {
            
            DataContextManager.DataContext.Routes.Add(route);
            if (getByIdRoute(route.Id).Equals(route))
            { return true; }
            return false;


        }
        public bool Update(int id, route route)
        {
            route r = DataContextManager.DataContext.Routes.Find(b => b.Id == id);
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
        public bool DeleteRoute(int id)
        {
            if (getByIdRoute(id) != null)
                return DataContextManager.DataContext.Routes.Remove(getByIdRoute(id));
            return false;
          

        }
        public List<route> GetByStation(int station)
        {
            return DataContextManager.DataContext.Routes.FindAll(b => b.Station==station);
        }
        public List<route> GetByBusLine(int busLine)
        {
            return DataContextManager.DataContext.Routes.FindAll(b => b.BusLineId==busLine);
        }
    }
}
