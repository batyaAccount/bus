using busesProject.pages;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace busesProject.Lists
{
    public class BusesList
    {
        public static List<bus> buses { get; set; } = new List<bus>();
        public List<bus> GetBuses() { return buses; }
        public bus getById(int id)
        {
            return buses.Find(z => z.Id == id);

        }
        public bool post(bus bus)
        {
            if (getById(bus.Id) != null)
            {
                return false;
            }
            buses.Add(bus);
            if (getById(bus.Id).Equals(bus))
            { return true; }
            return false;


        }
        public bool put(int id, bus bus)
        {
            bus bus1 = buses.Find(b => b.Id == id);
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
        public bool delete(int id)
        {
            if (getById(id) != null)
                return buses.Remove(getById(id));
            return false;
        }
        public List<bus> GetByDestination(string dest)
        {
            return buses.FindAll(b => b.DestinationStation == dest);
        }
    }
}
