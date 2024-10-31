namespace busesProject.pages
{    
    public enum typeBus { electric,byGaz }

    public class bus
    {
        public int Id { get; set; }
        public int BusLine { get; set; }
        public string SourceStation { get; set; }
        public string DestinationStation { get; set;}
        public typeBus Type { get; set; }
        public int TravelTime { get; set; }
        public bool IsActive { get; set; }

        public bus(int id, int busLine, string sourceStation, string destinationStation, typeBus type, int travelTime, bool isActive)
        {
            this.Id = id;
            this.BusLine = busLine;
            this.SourceStation = sourceStation;
            this.DestinationStation = destinationStation;
            this.Type = type;
            this.TravelTime = travelTime;
            this.IsActive = isActive;
        }
        public bus()
        {
            
        }
    }
}
