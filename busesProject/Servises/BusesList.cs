using busesProject.pages;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace busesProject.Lists
{
    public class BusesList
    {
        public List<bus> GetBuses() { return DataContextManager.DataContext.Buses; }
        public bus getByIdBuses(int id)
        {
            
            return DataContextManager.DataContext.Buses.Find(z => z.Id == id);

        }
        public bool Add(bus bus)
        {
            if (getByIdBuses(bus.Id) != null)
                DataContextManager.DataContext.Buses = new List<bus>();
            DataContextManager.DataContext.Buses.Add(bus);
            if (getByIdBuses(bus.Id).Equals(bus))
            { return true; }
            return false;


        }
        public bool Update(int id, bus bus)
        {
            bus bus1 = DataContextManager.DataContext.Buses.Find(b => b.Id == id);
            if (bus1 == null)
                return false;
            bus1.BusLine = bus.BusLine;
            bus1.SourceStation = bus.SourceStation;
            bus1.DestinationStation = bus.DestinationStation;
            bus1.IsActive = bus.IsActive;
            bus1.Type = bus.Type;
            bus1.TravelTime = bus.TravelTime;
            return true;

        }
        public bool DeleteBus(int id)
        {
            if (getByIdBuses(id) != null)
                return DataContextManager.DataContext.Buses.Remove(getByIdBuses(id));
            return false;
        }
        public List<bus> GetByDestination(string dest)
        {
            return DataContextManager.DataContext.Buses.FindAll(b => b.DestinationStation == dest);
        }
    }
}
